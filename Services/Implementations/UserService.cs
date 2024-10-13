using AutoMapper;
using Horizon_HR.Dtos.LeaveBalance;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Users;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Implementations;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Net;
using System.Text.Json;
using System.Text;
using Horizon_HR.Dtos.ResetPassword;

namespace Horizon_HR.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UserService> _logger;
        private readonly IFileStorageRepository _fileStorageService;
        private readonly IBankAccountService _bankAccountService;
        private readonly ILeaveBalanceService _leaveBalanceService;
        private readonly IResetPasswordRepository _resetPasswordRepository;

        public UserService(IUserRepository userRepository, IMapper mapper, ILogger<UserService> logger,
            IFileStorageRepository fileStorageService, IBankAccountService bankAccountService,
            ILeaveBalanceService leaveBalanceService, IResetPasswordRepository resetPasswordRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _logger = logger;
            _fileStorageService = fileStorageService;
            _bankAccountService = bankAccountService;
            _leaveBalanceService = leaveBalanceService;
            _resetPasswordRepository = resetPasswordRepository;
        }

        public async Task<PagedResult<UserDto>> GetAllUsersAsync(int pageNumber, int pageSize, string filter)
        {
            var pagedUsers = await _userRepository.GetAllUsersAsync(pageNumber, pageSize, filter);
            var pagedUsersDto = new PagedResult<UserDto>
            {
                Items = _mapper.Map<IEnumerable<UserDto>>(pagedUsers.Items),
                TotalItems = pagedUsers.TotalItems,
                PageNumber = pagedUsers.PageNumber,
                PageSize = pagedUsers.PageSize
            };

            return pagedUsersDto;
        }

        public async Task<UserDto> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<User>(createUserDto);
            var role = new String[] { "employee" };
            var payload = new
            {
                userName = createUserDto.Username,
                password = createUserDto.Password,
                roles = role,
                appSource = GlobalVariables.AppSource
            };


            var jsonPayload = JsonSerializer.Serialize(payload);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://20.199.23.144:8080");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("/api/Account/Register", content);

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    };
                    var result = JsonSerializer.Deserialize<ExternalApiResponse>(responseString, options);

                    if (user.ProfileImage != null)
                        user.ProfileImage = await _fileStorageService.StoreFileAsync(createUserDto.ProfileImage, "profile_images");
                    else
                        user.ProfileImage = "profile_images/default_employee_avatar.png";

                    var token = result.Token;
                    var handler = new JwtSecurityTokenHandler();
                    var decodedToken = handler.ReadJwtToken(token);

                    if (createUserDto.BankAccount != null)
                    {
                        var bankAccountDto = await _bankAccountService.CreateBankAccountAsync(createUserDto.BankAccount);
                        user.BankAccountId = bankAccountDto.Id;

                    }

                    var userId = decodedToken.Claims.First(c => c.Type == "userId").Value;
                    user.Id = Guid.Parse(userId);
                    await _userRepository.CreateUserAsync(user);
                    

                    var newLeaveBalance = new CreateLeaveBalanceDto
                    {
                        Annual = 0,
                        Sick = 10,
                        UserId = user.Id
                    };

                    await _leaveBalanceService.CreateUserLeaveBalanceAsync(newLeaveBalance);

                    return _mapper.Map<UserDto>(user);
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Error Response: " + errorContent);
                    throw new Exception($"Failed to create user: {errorContent}");
                }
            }
        }

        public async Task<UserDto> GetUserByIdAsync(Guid id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> UpdateUserAsync(Guid id, UpdateUserDto updateUserDto)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
           
            if (user == null)
                throw new Exception("User not found");

            if (updateUserDto.Password != null)
            {
                var request = new RequestResetPasswordDto
                {
                    Username = updateUserDto.Username,
                    NewPassword = updateUserDto.Password
                };

                bool result = await _resetPasswordRepository.ResetPassword(request);
            }

            if (updateUserDto.BankAccount != null)
                _mapper.Map(updateUserDto, user);

            else
            {
                if (user.BankAccountId != null)
                {
                    var bankAccount = await _bankAccountService.GetBankAccountByIdAsync(user.BankAccountId.Value);
                    if (bankAccount != null)
                        await _bankAccountService.DeleteBankAccountAsync(user.BankAccountId.Value);

                    user.BankAccountId = null;
                }
            }

            _mapper.Map(updateUserDto, user);

            var newProfileImage = updateUserDto.ProfileImage;
            if (newProfileImage != null)
            {
                var currentProfileImage = user.ProfileImage;
                if (!string.IsNullOrEmpty(currentProfileImage))
                    _fileStorageService.DeleteFile(currentProfileImage);
                user.ProfileImage = await _fileStorageService.StoreFileAsync(newProfileImage, "profile_images");
            }

            user.UpdatedAt = DateTime.UtcNow;

            var updatedUser = await _userRepository.UpdateUserAsync(user);

            return _mapper.Map<UserDto>(updatedUser);
        }

        public async Task DeleteUserAsync(Guid id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null)
            {
                _logger.LogWarning($"User with ID {id} not found.");
                throw new Exception("User not found");
            }

            var profileImage = user.ProfileImage;
            if (!string.IsNullOrEmpty(profileImage))
                _fileStorageService.DeleteFile(profileImage);

           
            await _userRepository.DeleteUserAsync(user);

        }
    }
}
