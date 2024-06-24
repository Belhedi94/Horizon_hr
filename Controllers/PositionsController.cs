using Horizon_HR.Dtos.Positions;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [Route("api/positions/")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly IPositionRepository _positionServices;

        public PositionsController(IPositionRepository positionServices)
        {
            _positionServices = positionServices;
        }

        /// <summary>
        /// Creates a new position.
        /// </summary>
        /// <param name="createPositionDto">The data transfer object containing position information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPost]
        public async Task<IActionResult> CreatePositionAsync(CreatePositionDto createPositionDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _positionServices.CreatePositionAsync(createPositionDto);

            return Ok(new {message = "Position created successfully."});
        }

        /// <summary>
        /// Updates an existing position.
        /// </summary>
        /// <param name="id">The ID of the position to update.</param>
        /// <param name="updatePositionDto">The data transfer object containing updated position information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePositionAsync(Guid id, UpdatePositionDto updatePositionDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _positionServices.UpdatePositionAsync(id, updatePositionDto);

            return Ok(new { message = "Position updated successfully." });
        }

        /// <summary>
        /// Retrieves all positions.
        /// </summary>
        /// <returns>A list of all positions.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllPositionsAsync()
        {
            var positions = await _positionServices.GetAllPositionsAsync();
            if (!positions.Any())
                return Ok(new { message = "No positions found", data = Enumerable.Empty<PositionDto>() });

            return Ok(new { message = "Positions retrieved successfully", data = positions });

        }

        /// <summary>
        /// Retrieves a position by ID.
        /// </summary>
        /// <param name="id">The ID of the position to retrieve.</param>
        /// <returns>The position data.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPositionByIdAsync(Guid id)
        {
            var position = await _positionServices.GetPositionByIdAsync(id);
            return Ok(new { message = "Position retrieved successfully.", data = position });
        }

        /// <summary>
        /// Deletes a position by ID.
        /// </summary>
        /// <param name="id">The ID of the position to delete.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePositionAsync(Guid id)
        {
            await _positionServices.DeletePositionAsync(id);
            return Ok(new { message = "Position deleted successfully." });
        }
    }
}
