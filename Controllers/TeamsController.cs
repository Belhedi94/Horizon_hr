using Horizon_HR.Dtos.ApiResponse;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Teams;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [Route("api/teams/")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamRepository _teamRepository;
        private readonly ITeamService _teamService;

        public TeamsController(ITeamRepository teamRepository, ITeamService teamService)
        {
            _teamRepository = teamRepository;
            _teamService = teamService;
        }

        /// <summary>
        /// Retrieves all teams.
        /// </summary>
        /// <returns>A list of all teams.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllTeamsAsync(int pageNumber = 1, int pageSize = 10, string filter = null, bool usePagination = true)
        {
            var teams = await _teamService.GetAllTeamsAsync(pageNumber, pageSize, filter, usePagination);
            if (!teams.Items.Any())
                return Ok(new ApiResponse<PagedResult<TeamDto>>
                {
                    Status = 404,
                    Message = "No teams found.",
                    Data = new PagedResult<TeamDto>
                    {
                        Items = Enumerable.Empty<TeamDto>(),
                        TotalItems = 0,
                        PageNumber = pageNumber,
                        PageSize = pageSize
                    }
                });

            return Ok(new ApiResponse<PagedResult<TeamDto>>
            {
                Status = 200,
                Message = "Teams retrieved successfully.",
                Data = teams
            });

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

            await _teamRepository.CreateTeamAsync(createTeamDto);

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

            await _teamRepository.UpdateTeamAsync(id, updateTeamDto);

            return Ok(new { message = "Team updated successfully." });
        }

        /// <summary>
        /// Retrieves a team by ID.
        /// </summary>
        /// <param name="id">The ID of the team to retrieve.</param>
        /// <returns>The team data.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeamByIdAsync(Guid id)
        {
            var team = await _teamRepository.GetTeamByIdAsync(id);
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
            await _teamRepository.DeleteTeamAsync(id);
            return Ok(new { message = "Team deleted successfully." });
        }
    }
}
