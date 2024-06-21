using Horizon_HR.Contracts.Users;
using Horizon_HR.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [ApiController]
    [Route("api/users/")]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UsersController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserAsync(CreateUserDto createUserDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _userServices.CreateUserAsync(createUserDto);
            return Ok(new {message = "User created successfully."});
            
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _userServices.GetAllUsersAsync();
            if (!users.Any())
                return Ok(new { message = "No users found", data = Enumerable.Empty<UserDto>()} );

            return Ok(new { message = "Users retrieved successfully", data = users });
          
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserAsync(Guid id, UpdateUserDto updateUserDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _userServices.UpdateUserAsync(id, updateUserDto);

            return Ok(new { message = "User updated successfully." });
        }
    }
}
