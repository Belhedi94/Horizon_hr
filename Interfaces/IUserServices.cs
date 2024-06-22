using Horizon_HR.Contracts.Users;

namespace Horizon_HR.Interfaces
{
    public interface IUserServices
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task CreateUserAsync(CreateUserDto createUserDto);
        Task<UserDto> GetUserByIdAsync(Guid id);
        Task UpdateUserAsync(Guid id, UpdateUserDto updateUserDto);
        Task DeleteUserAsync(Guid id);
    }
}
