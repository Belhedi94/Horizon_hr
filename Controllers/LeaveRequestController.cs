using Horizon_HR.Dtos.ApiResponse;
using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Positions;
using Horizon_HR.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [ApiController]
    [Route("api/requests/leaves/")]
    public class LeaveRequestController : ControllerBase
    {
        private readonly ILeaveRequestService _leaveRequestService;

        public LeaveRequestController(ILeaveRequestService leaveRequestService)
        {
            _leaveRequestService = leaveRequestService;
        }

        /// <summary>
        /// Retrieves all leave requests.
        /// </summary>
        /// <returns>A list of all leave requests.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllLeaveRequestsAsync(int pageNumber = 1, int pageSize = 10, string filter = null, bool usePagintion = true)
        {
            var leaveRequests = await _leaveRequestService.GetAllLeaveRequestsAsync(pageNumber, pageSize, filter, usePagintion);
            if (!leaveRequests.Items.Any())
                return Ok(new ApiResponse<PagedResult<LeaveRequestDto>>
                {
                    Status = 404,
                    Message = "No leave requests found.",
                    Data = new PagedResult<LeaveRequestDto>
                    {
                        Items = Enumerable.Empty<LeaveRequestDto>(),
                        TotalItems = 0,
                        PageNumber = pageNumber,
                        PageSize = pageSize
                    }
                });

            return Ok(new ApiResponse<PagedResult<LeaveRequestDto>>
            {
                Status = 200,
                Message = "Leave requests retrieved successfully.",
                Data = leaveRequests
            });

        }

        [HttpPost]
        public async Task<IActionResult> SubmitLeaveRequest(CreateLeaveRequestDto createLeaveRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _leaveRequestService.SubmitLeaveRequestAsync(createLeaveRequestDto);

            if (result.IsSuccess)
                return Created();
            else
                return BadRequest(result.ErrorMessage);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetLeaveRequestsByUserAsync(Guid userId)
        {
            var result = await _leaveRequestService.GetLeaveRequestsByUserAsync(userId);

            if (result.IsSuccess)
                return Ok(result.Data);
            else
                return NotFound(result.ErrorMessage);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLeaveRequestsAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _leaveRequestService.UpdateLeaveRequestAsync(id, updateLeaveRequestDto);

            if (result.IsSuccess)
                return Ok(result.Data);
            else
                return NotFound(result.ErrorMessage);
        }
    }
}
