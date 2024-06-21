using Horizon_HR.Contracts.Users;
using Horizon_HR.Models;

namespace Horizon_HR.Interfaces
{
    public interface IUserServices
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task CreateUserAsync(CreateUserDto createUserDto);
        Task<User> GetUserByIdAsync(Guid id);
        Task UpdateUserAsync(Guid id, UpdateUserDto updateUserDto);
        Task DeleteUserAsync(Guid id);
    }
}
