using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Users;

namespace Horizon_HR.Services.Interfaces
{
    public interface IUserService
    {
        Task<PagedResult<UserDto>> GetAllUsersAsync(int pageNumber, int pageSize, string filter);
        Task<UserDto> CreateUserAsync(CreateUserDto createUserDto);
        Task<UserDto> GetUserByIdAsync(Guid id);
        Task<UserDto> UpdateUserAsync(Guid id, UpdateUserDto updateUserDto);
        Task DeleteUserAsync(Guid id);
    }
}
