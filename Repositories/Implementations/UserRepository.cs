using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Horizon_HR.Dtos.PagedResult;

namespace Horizon_HR.Repositories.Implementations
{

    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext _context;
        private readonly ILogger<UserRepository> _logger;
       

        public UserRepository(DataBaseContext context, ILogger<UserRepository> logger)
        {
            _context = context;
            _logger = logger;
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

        public async Task<User> UpdateUserAsync(User user)
        {
            var userData = await GetUserByIdAsync(user.Id);
            if (userData == null)
            {
                userData = user;
            }

            await _context.SaveChangesAsync();

            return userData;
        }

        public async Task DeleteUserAsync(User user)
        {
            _context.Users.Remove(user);

            await _context.SaveChangesAsync();

        }
    }
}
