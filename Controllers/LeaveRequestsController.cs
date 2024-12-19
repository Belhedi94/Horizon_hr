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
    public class LeaveRequestsController : ControllerBase
    {
        private readonly ILeaveRequestService _leaveRequestService;

        public LeaveRequestsController(ILeaveRequestService leaveRequestService)
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
        /// <returns>
        /// An API response object with the following possible outcomes:
        /// - **201 Created**: The leave request was successfully submitted. The response includes the submitted leave request details.
        /// - **400 Bad Request**: The request failed due to validation errors or insufficient leave balance. The response includes the error message.
        /// </returns>
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
                    Message = result.Message,
                    Data = result.Data
                });
        }

        /// <summary>
        /// Get leave request by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// An API response object with the following possible outcomes:
        /// - **200 Created**: The leave request was successfully retrieved. The response includes the requested leave request details.
        /// - **404 Not found**: The request failed due to non-existence of the leave request.
        /// </returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLeaveRequestByIdAsync(Guid id)
        {
            var result = await _leaveRequestService.GetLeaveRequestByIdAsync(id);

            if (result.IsSuccess)
                return Ok(new ApiResponse<LeaveRequestDto>()
                {
                    Status = 200,
                    Message = result.Message,
                    Data = result.Data
                });
            else
                return NotFound(new ApiResponse<LeaveRequestDto>()
                {
                    Status = 404,
                    Message = result.Message
                });
        }

        /// <summary>
        /// Get leave request by user id.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>
        /// An API response object with the following possible outcomes:
        /// - **200 Created**: The leave request was successfully retrieved. The response includes the requested leave request details.
        /// - **404 Not found**: The request failed due to non-existence of the leave request.
        /// </returns>
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetLeaveRequestsByUserAsync(Guid userId)
        {
            var result = await _leaveRequestService.GetLeaveRequestsByUserAsync(userId);

            if (result.IsSuccess)
                return Ok(new ApiResponse<IEnumerable<LeaveRequestDto>>()
                {
                    Status = 200,
                    Message = result.Message,
                    Data = result.Data
                });
            else
                return NotFound(new ApiResponse<LeaveRequestDto>()
                {
                    Status = 404,
                    Message = result.Message
                });
        }

        /// <summary>
        /// Update leave request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateLeaveRequestDto"></param>
        /// <returns>
        /// - **200 Created**: The leave request was successfully updated. The response includes the updated leave request details.
        /// - **404 Not found**: The request failed due to non-existence of the leave request. 
        /// </returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLeaveRequestsAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _leaveRequestService.UpdateLeaveRequestAsync(id, updateLeaveRequestDto);

            if (result.IsSuccess)
                return Ok(new ApiResponse<LeaveRequestDto>()
                {
                    Status = 200,
                    Message = result.Message,
                    Data = result.Data
                });
            else
                return NotFound(new ApiResponse<LeaveRequestDto>()
                {
                    Status = 404,
                    Message = result.Message
                });
        }
    }
}
