using Horizon_HR.Contracts.Teams;
using Horizon_HR.Contracts.Users;
using Horizon_HR.Interfaces;
using Horizon_HR.Services;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [Route("api/teams/")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamServices _teamServices;

        public TeamsController(ITeamServices teamServices)
        {
            _teamServices = teamServices;
        }

        /// <summary>
        /// Creates a new team.
        /// </summary>
        /// <param name="createTeamDto">The data transfer object containing team information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateTeamAsync(CreateTeamDto createTeamDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _teamServices.CreateTeamAsync(createTeamDto);

            return Ok(new {message = "Team created successfully."});
        }

        /// <summary>
        /// Updates an existing team.
        /// </summary>
        /// <param name="id">The ID of the team to update.</param>
        /// <param name="updateTeamDto">The data transfer object containing updated team information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeamAsync(Guid id, UpdateTeamDto updateTeamDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _teamServices.UpdateTeamAsync(id, updateTeamDto);

            return Ok(new { message = "Team updated successfully." });
        }

        /// <summary>
        /// Retrieves all teams.
        /// </summary>
        /// <returns>A list of all teams.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllTeamsAsync()
        {
            var teams = await _teamServices.GetAllTeamsAsync();
            if (!teams.Any())
                return Ok(new { message = "No teams found", data = Enumerable.Empty<TeamDto>() });

            return Ok(new { message = "Teams retrieved successfully", data = teams });

        }

        /// <summary>
        /// Retrieves a team by ID.
        /// </summary>
        /// <param name="id">The ID of the team to retrieve.</param>
        /// <returns>The team data.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeamByIdAsync(Guid id)
        {
            var team = await _teamServices.GetTeamByIdAsync(id);
            return Ok(new { message = "Team retrieved successfully.", data = team });
        }

        /// <summary>
        /// Deletes a team by ID.
        /// </summary>
        /// <param name="id">The ID of the team to delete.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamAsync(Guid id)
        {
            await _teamServices.DeleteTeamAsync(id);
            return Ok(new { message = "Team deleted successfully." });
        }
    }
}
