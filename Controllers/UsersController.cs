using Horizon_HR.Dtos.ApiResponse;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Positions;
using Horizon_HR.Dtos.Users;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Implementations;
using Horizon_HR.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [ApiController]
    [Route("api/users/")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserService _userService;

        public UsersController(IUserRepository userRepository, IUserService uSerService)
        {
            _userRepository = userRepository;
            _userService = uSerService;
        }

        /// <summary>
        /// Retrieves all users.
        /// </summary>
        /// <returns>A list of all users.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync(int pageNumber = 1, int pageSize = 10, string filter = null)
        {
            var users = await _userService.GetAllUsersAsync(pageNumber, pageSize, filter);
            if (!users.Items.Any())
                return Ok(new ApiResponse<PagedResult<UserDto>>
                {
                    Status = 404,
                    Message = "No users found.",
                    Data = new PagedResult<UserDto>
                    {
                        Items = Enumerable.Empty<UserDto>(),
                        TotalItems = 0,
                        PageNumber = pageNumber,
                        PageSize = pageSize
                    }
                });

            return Ok(new ApiResponse<PagedResult<UserDto>>
            {
                Status = 200,
                Message = "Employees retrieved successfully.",
                Data = users
            });

        }

        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="createUserDto">The data transfer object containing user information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateUserAsync(CreateUserDto createUserDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newUser = await _userService.CreateUserAsync(createUserDto);

            return Ok(new ApiResponse<UserDto>
            {
                Status = 201,
                Message = "Employee created successfully.",
                Data = newUser
            });
        }

        /// <summary>
        /// Updates an existing user.
        /// </summary>
        /// <param name="id">The ID of the user to update.</param>
        /// <param name="updateUserDto">The data transfer object containing updated user information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserAsync(Guid id, UpdateUserDto updateUserDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updatedUser = await _userService.UpdateUserAsync(id, updateUserDto);

            return Ok(new ApiResponse<UserDto>
            {
                Status = 200,
                Message = "Employee updated successfully.",
                Data = updatedUser
            });
        }

        /// <summary>
        /// Retrieves a user by ID.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>The user data.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserByIdAsync(Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);

            return Ok(new ApiResponse<UserDto>
            {
                Status = 200,
                Message = "Employee retrieved successfully.",
                Data = user
            });
        }

        /// <summary>
        /// Deletes a user by ID.
        /// </summary>
        /// <param name="id">The ID of the user to delete.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserAsync(Guid id)
        {
            await _userRepository.DeleteUserAsync(id);
            return Ok(new { message = "User deleted successfully." });
        }
    }
}
