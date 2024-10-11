using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Users;
using Horizon_HR.Models;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<PagedResult<User>> GetAllUsersAsync(int pageNumber, int pageSize, string filter);
        Task<User> CreateUserAsync(User user);
        Task<User> GetUserByIdAsync(Guid id);
        Task<User> UpdateUserAsync(Guid id, User user);
        Task DeleteUserAsync(Guid id);
    }
}
