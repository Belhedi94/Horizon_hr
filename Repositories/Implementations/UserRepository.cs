using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Dtos.Users;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Net;
using System.IdentityModel.Tokens.Jwt;
using Horizon_HR.Dtos.BankAccount;


namespace Horizon_HR.Repositories.Implementations
{

    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext _context;
        private readonly ILogger<UserRepository> _logger;
        private readonly IMapper _mapper;
        private readonly IFileStorageRepository _fileStorageService;

        public UserRepository(DataBaseContext context, ILogger<UserRepository> logger, IMapper mapper,
            IFileStorageRepository fileStorageService)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var users = await _context.Users.ToListAsync();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }

        public async Task CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<User>(createUserDto);
            var role = new String[] { "hrmanager_admin" };
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

                    CreateBankAccountDto bankAccountData;
                    if (createUserDto.BankAccount != null)
                    {
                        bankAccountData = createUserDto.BankAccount;
                        var bankAccountEntity = _mapper.Map<BankAccount>(bankAccountData);
                        _context.Add(bankAccountEntity);
                        await _context.SaveChangesAsync();

                        var bankAccountId = bankAccountEntity.Id;
                        user.BankAccountId = bankAccountId;
                        
                    }

                    var userId = decodedToken.Claims.First(c => c.Type == "userId").Value;
                    user.Id = Guid.Parse(userId);
                    _context.Add(user);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Error Response: " + errorContent);
                    throw new Exception($"Failed to create user: {errorContent}");
                }
            }
        }

        public async Task UpdateUserAsync(Guid id, UpdateUserDto updateUserDto)
        {
            var user = await _context.Users
                .Include(u => u.EmploymentDetails)
                .Include(u => u.BankAccount)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
                throw new Exception("User not found");

            _mapper.Map(updateUserDto, user);

            if (updateUserDto.EmploymentDetails != null)
            {
                if (user.EmploymentDetails != null)
                    _mapper.Map(updateUserDto.EmploymentDetails, user.EmploymentDetails);

                else
                    user.EmploymentDetails = _mapper.Map<EmploymentDetails>(updateUserDto.EmploymentDetails);
            }

            if (updateUserDto.BankAccount != null)
            {
                if (user.BankAccount != null)
                    _mapper.Map(updateUserDto.BankAccount, user.BankAccount);

                else
                    user.BankAccount = _mapper.Map<BankAccount>(updateUserDto.BankAccount);
            }


            //var newCv = updateUserDto.Cv;
            //if (newCv != null)
            //{
            //    var currentCv = user.Cv;
            //    if (!string.IsNullOrEmpty(currentCv))
            //        _fileStorageService.DeleteFile(currentCv);
            //    user.Cv = await _fileStorageService.StoreFileAsync(newCv, "cvs");
            //}

            var newProfileImage = updateUserDto.ProfileImage;
            if (newProfileImage != null)
            {
                var currentProfileImage = user.ProfileImage;
                if (!string.IsNullOrEmpty(currentProfileImage))
                    _fileStorageService.DeleteFile(currentProfileImage);
                user.ProfileImage = await _fileStorageService.StoreFileAsync(newProfileImage, "profile_images");
            }

            user.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
        }

        public async Task<UserDto> GetUserByIdAsync(Guid id)
        {
            var user = await _context.Users
                .Include(u => u.EmploymentDetails)
                .Include(u => u.BankAccount)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                _logger.LogWarning($"User with ID {id} not found.");
                throw new Exception("User not found");
            }

            return _mapper.Map<UserDto>(user);

        }

        public async Task DeleteUserAsync(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                _logger.LogWarning($"User with ID {id} not found.");
                throw new Exception("User not found");
            }

            //var cv = user.Cv;
            //if (!string.IsNullOrEmpty(cv))
            //    _fileStorageService.DeleteFile(cv);

            var profileImage = user.ProfileImage;
            if (!string.IsNullOrEmpty(profileImage))
                _fileStorageService.DeleteFile(profileImage);

            _context.Users.Remove(user);

            await _context.SaveChangesAsync();

        }
    }
}
