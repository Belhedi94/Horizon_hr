using Horizon_HR.Dtos.ApiResponse;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Positions;
using Horizon_HR.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [Route("api/positions/")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly IPositionService _positionService;

        public PositionsController(IPositionService positionServices)
        {
            _positionService = positionServices;
        }

        /// <summary>
        /// Retrieves all positions.
        /// </summary>
        /// <returns>A list of all positions.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllPositionsAsync(int pageNumber = 1, int pageSize = 10, string filter = null,
            bool usePagination = true)
        {
            var positions = await _positionService.GetAllPositionsAsync(pageNumber, pageSize, filter, usePagination);
            if (!positions.Items.Any())
                return Ok(new ApiResponse<PagedResult<PositionDto>>
                {
                    Status = 404,
                    Message = "No positions found.",
                    Data = new PagedResult<PositionDto>
                    {
                        Items = Enumerable.Empty<PositionDto>(),
                        TotalItems = 0,
                        PageNumber = pageNumber,
                        PageSize = pageSize
                    }
                });

            return Ok(new ApiResponse<PagedResult<PositionDto>>
            {
                Status = 200,
                Message = "Positions retrieved successfully.",
                Data = positions
            });

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
                return BadRequest(ModelState);

            var newPosition = await _positionService.CreatePositionAsync(createPositionDto);

            return Ok(new ApiResponse<PositionDto>
            {
                Status = 201,
                Message = "Position created successfully.",
                Data = newPosition
            });
        }

        /// <summary>
        /// Retrieves a position by ID.
        /// </summary>
        /// <param name="id">The ID of the position to retrieve.</param>
        /// <returns>The position data.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPositionByIdAsync(Guid id)
        {
            var position = await _positionService.GetPositionByIdAsync(id);

            return Ok(new ApiResponse<PositionDto>
            {
                Status = 200,
                Message = "Position retrieved successfully.",
                Data = position
            });
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

            var updatedPosition = await _positionService.UpdatePositionAsync(id, updatePositionDto);

            return Ok(new ApiResponse<PositionDto>
            {
                Status = 200,
                Message = "Position updated successfully.",
                Data = updatedPosition
            });
        }


        /// <summary>
        /// Deletes a position by ID.
        /// </summary>
        /// <param name="id">The ID of the position to delete.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePositionAsync(Guid id)
        {
            await _positionService.DeletePositionAsync(id);

            return Ok(new ApiResponse<PositionDto>
            {
                Status = 200,
                Message = "Position deleted successfully.",
                Data = {}
            });
        }
    }
}
