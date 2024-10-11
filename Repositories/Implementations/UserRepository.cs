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
using Horizon_HR.Dtos.ResetPassword;
using Horizon_HR.Services.Interfaces;
using Horizon_HR.Dtos.LeaveBalance;
using Horizon_HR.Dtos.PagedResult;

namespace Horizon_HR.Repositories.Implementations
{

    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext _context;
        private readonly ILogger<UserRepository> _logger;
        private readonly IMapper _mapper;
        private readonly IFileStorageRepository _fileStorageService;
        private readonly IResetPasswordRepository _resetPasswordRepository;
        private readonly ILeaveBalanceService _leaveBalanceService;

        public UserRepository(DataBaseContext context, ILogger<UserRepository> logger, IMapper mapper,
            IFileStorageRepository fileStorageService, IResetPasswordRepository resetPasswordRepository,
            ILeaveBalanceService leaveBalanceService)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
            _resetPasswordRepository = resetPasswordRepository;
            _leaveBalanceService = leaveBalanceService;
        }

        public async Task<PagedResult<User>> GetAllUsersAsync(int pageNumber, int pageSize, string filter)
        {
            var query = _context.Users.AsQueryable();

            if (!string.IsNullOrEmpty(filter))
                query = query.Where(u => u.FirstName.Contains(filter) ||
                u.LastName.Contains(filter) ||
                u.Username.Contains(filter) ||
                u.Status.Contains(filter) ||
                u.PersonalEmail.Contains(filter) ||
                u.ProfessionalEmail.Contains(filter) ||
                u.ProfessionalEmail.Contains(filter) ||
                u.PersonalPhone.Contains(filter) ||
                u.Cin.Contains(filter) ||
                u.CnssRegistrationNumber.Contains(filter) ||
                u.Address.Contains(filter));

            var totalCount = await query.CountAsync();

            var users = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Include(u => u.EmploymentDetails)
                .Include(u => u.BankAccount)
                .ToListAsync();

            return new PagedResult<User>
            {
                Items = users,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public async Task<User> CreateUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        //public async Task UpdateUserAsync(Guid id, UpdateUserDto updateUserDto)
        //{
            //var user = await _context.Users
            //    .Include(u => u.EmploymentDetails)
            //    .Include(u => u.BankAccount)
            //    .FirstOrDefaultAsync(u => u.Id == id);

            //if (user == null)
            //    throw new Exception("User not found");

            //if (updateUserDto.Password != null)
            //{
            //    var request = new RequestResetPasswordDto
            //    {
            //        Username = updateUserDto.Username,
            //        NewPassword = updateUserDto.Password
            //    };

            //    bool result = await _resetPasswordRepository.ResetPassword(request);
            //}

            //if (updateUserDto.BankAccount != null)
            //    _mapper.Map(updateUserDto, user);
            //else
            //{
            //    if (user.BankAccountId != null)
            //    {
            //        var bankAccount = await _context.BankAccounts.FindAsync(user.BankAccountId);
            //        if (bankAccount != null)
            //            _context.BankAccounts.Remove(bankAccount);
            //        user.BankAccountId = null;
            //    }
            //}

            //_mapper.Map(updateUserDto, user);

            //var newProfileImage = updateUserDto.ProfileImage;
            //if (newProfileImage != null)
            //{
            //    var currentProfileImage = user.ProfileImage;
            //    if (!string.IsNullOrEmpty(currentProfileImage))
            //        _fileStorageService.DeleteFile(currentProfileImage);
            //    user.ProfileImage = await _fileStorageService.StoreFileAsync(newProfileImage, "profile_images");
            //}

            //user.UpdatedAt = DateTime.UtcNow;

            //await _context.SaveChangesAsync();
        //}

        public async Task<User> GetUserByIdAsync(Guid id)
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

            return user;

        }

        public async Task DeleteUserAsync(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                _logger.LogWarning($"User with ID {id} not found.");
                throw new Exception("User not found");
            }

            var profileImage = user.ProfileImage;
            if (!string.IsNullOrEmpty(profileImage))
                _fileStorageService.DeleteFile(profileImage);

            _context.Users.Remove(user);

            await _context.SaveChangesAsync();

        }

        public Task<User> UpdateUserAsync(Guid id, User user)
        {
            
        }
    }
}
