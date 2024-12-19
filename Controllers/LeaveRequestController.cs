using Horizon_HR.Dtos.ApiResponse;
using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Models;
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
        public async Task<IActionResult> GetAllLeaveRequestsAsync(int pageNumber = 1, int pageSize = 10,
            string filter = null, bool usePagination = true, bool forDashboard = false)
        {
            var leaveRequests = await _leaveRequestService.GetAllLeaveRequestsAsync(pageNumber, pageSize,
                filter, usePagination, forDashboard);
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

        /// <summary>
        /// Submit a new leave request.
        /// </summary>
        /// <param name="createLeaveRequestDto">The data transfer object containing leave request data.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPost]
        public async Task<IActionResult> SubmitLeaveRequest(CreateLeaveRequestDto createLeaveRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _leaveRequestService.SubmitLeaveRequestAsync(createLeaveRequestDto);

            if (result.IsSuccess)
                return Ok(new ApiResponse<LeaveRequest>
                {
                    Status = 201,
                    Message = "Leave request submitted successfully.",
                    Data = result.Data
                });
            else
                return BadRequest(new ApiResponse<LeaveRequest>
                {
                    Status = 400,
                    Message = result.ErrorMessage,
                    Data = result.Data
                });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLeaveRequestByIdAsync(Guid id)
        {
            var result = await _leaveRequestService.GetLeaveRequestByIdAsync(id);

            if (result.IsSuccess)
                return Ok(result.Data);
            else
                return NotFound(result.ErrorMessage);
        }

        [HttpGet("user/{userId}")]
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
