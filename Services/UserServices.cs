using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Contracts.Users;
using Horizon_HR.Interfaces;
using Horizon_HR.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;


namespace Horizon_HR.Services
{

    public class UserServices : IUserServices
    {
        private readonly DataBaseContext _context;
        private readonly ILogger<UserServices> _logger;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;

        public UserServices(DataBaseContext context, ILogger<UserServices> logger, IMapper mapper,
            IFileStorageService fileStorageService)
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
            using (var hmac = new HMACSHA512())
            {
                user.PasswordSalt = hmac.Key;
                user.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(createUserDto.Password));
            }

            if (user.Cv != null)
                user.Cv = await _fileStorageService.StoreFileAsync(createUserDto.Cv, "cvs");

            if (user.ProfileImage != null)
                user.ProfileImage = await _fileStorageService.StoreFileAsync(createUserDto.ProfileImage, "profile_images");

            _context.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(Guid id, UpdateUserDto updateUserDto)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                throw new Exception("User not found");

            _mapper.Map(updateUserDto, user);

            var password = updateUserDto.Password;
            if (!string.IsNullOrEmpty(password))
            {
                using (var hmac = new HMACSHA512())
                {
                    user.PasswordSalt = hmac.Key;
                    user.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                }
            }

            var newCv = updateUserDto.Cv;
            if (newCv != null)
            {
                var currentCv = user.Cv;
                if (!string.IsNullOrEmpty(currentCv))
                    _fileStorageService.DeleteFile(currentCv);
                user.Cv = await _fileStorageService.StoreFileAsync(newCv, "cvs");
            }

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
            var user = await _context.Users.FindAsync(id);
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

            var cv = user.Cv;
            if (!string.IsNullOrEmpty(cv))
                _fileStorageService.DeleteFile(cv);

            var profileImage = user.ProfileImage;
            if (!string.IsNullOrEmpty(profileImage))
                _fileStorageService.DeleteFile(profileImage);

            _context.Users.Remove(user);

            await _context.SaveChangesAsync();

        }
    }
}
