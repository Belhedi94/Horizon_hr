using Horizon_HR.Dtos.Users;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [ApiController]
    [Route("api/users/")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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

            await _userRepository.CreateUserAsync(createUserDto);
            return Ok(new {message = "User created successfully."});
            
            
        }

        /// <summary>
        /// Retrieves all users.
        /// </summary>
        /// <returns>A list of all users.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();
            if (!users.Any())
                return Ok(new { message = "No users found", data = Enumerable.Empty<UserDto>()} );

            return Ok(new { message = "Users retrieved successfully", data = users });
          
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

            await _userRepository.UpdateUserAsync(id, updateUserDto);

            return Ok(new { message = "User updated successfully." });
        }

        /// <summary>
        /// Retrieves a user by ID.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>The user data.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserByIdAsync(Guid id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            return Ok(new { message = "User retrieved successfully.", data = user });
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
