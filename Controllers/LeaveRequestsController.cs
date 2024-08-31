using Horizon_HR.Dtos.LeaveBalance;
using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [Route("api/requests/leaves")]
    [ApiController]
    public class LeaveRequestsController : ControllerBase
    {
        public readonly ILeaveRequestRepository _leaveRequestRepository;
        public readonly ILeaveBalanceRepository _leaveBalanceRepository;

        public LeaveRequestsController(ILeaveRequestRepository leaveRequestRepository, ILeaveBalanceRepository leaveBalanceRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _leaveBalanceRepository = leaveBalanceRepository;
        }

        /// <summary>
        /// Retrieves all leave requests.
        /// </summary>
        /// <returns>A list of all leave requests.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllLeaveRequestsAsync()
        {
            var leaveRequests = await _leaveRequestRepository.GetAllLeaveRequestsAsync();
            if (!leaveRequests.Any())
                return Ok(new { message = "No leave requests found", data = Enumerable.Empty<LeaveRequestDto>() });

            return Ok(new { message = "Leave requests retrieved successfully", data = leaveRequests });

        }

        /// <summary>
        /// Retrieves a leave request by ID.
        /// </summary>
        /// <param name="id">The ID of the leave request to retrieve.</param>
        /// <returns>The leave request data.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLeaveRequestByIdAsync(Guid id)
        {
            var leaveRequest = await _leaveRequestRepository.GetLeaveRequestByIdAsync(id);
            return Ok(new { message = "Leave request retrieved successfully.", data = leaveRequest });
        }

        /// <summary>
        /// Retrieves a leave request by user Id.
        /// </summary>
        /// <param name="userId">The ID of the user</param>
        /// <returns>The leave requests list of that user.</returns>
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetLeaveRequestByUserIdAsync(Guid userId)
        {
            var leaveRequests = await _leaveRequestRepository.GetLeaveRequestsByUserIdAsync(userId);
            if (!leaveRequests.Any())
                return Ok(new { message = "No leave requests found for that user", data = Enumerable.Empty<LeaveRequestDto>() });

            return Ok(new { message = "Leave requests retrieved successfully", data = leaveRequests });
        }

        /// <summary>
        /// Creates a new leave request.
        /// </summary>
        /// <param name="createLeaveRequestDto">The data transfer object containing leave request informations.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPost]
        public async Task<IActionResult> AddLeaveRequestAsync(CreateLeaveRequestDto createLeaveRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var leaveBalance = await _leaveBalanceRepository.GetLeaveBalanceByUserIdAsync(createLeaveRequestDto.UserId);
            var totalLeaveDays = (createLeaveRequestDto.EndDate - createLeaveRequestDto.StartDate).Days + 1;

            if (leaveBalance.UsedLeaveDays >= totalLeaveDays)
            {
                leaveBalance.UsedLeaveDays = totalLeaveDays;
                var updateLeaveBalanceDto = new UpdateLeaveBalanceDto
                {
                    UserId = leaveBalance.UserId,
                    UsedLeaveDays = leaveBalance.UsedLeaveDays + totalLeaveDays,
                    TotalLeaveDays = leaveBalance.TotalLeaveDays
                };

                await _leaveBalanceRepository.UpdateLeaveBalanceAsync(updateLeaveBalanceDto);

                await _leaveRequestRepository.AddLeaveRequestAsync(createLeaveRequestDto);
                return Ok(new { message = "Leave request created successfully." });
            }
            else
                return BadRequest("Not enough leave balance");
        }

        /// <summary>
        /// Updates an existing leave request.
        /// </summary>
        /// <param name="id">The ID of the leave request to update.</param>
        /// <param name="updateLeaveRequestDto">The data transfer object containing updated leave request informations.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLeaveRequestAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _leaveRequestRepository.UpdateLeaveRequestAsync(id, updateLeaveRequestDto);

            return Ok(new { message = "Leave request updated successfully." });
        }

        /// <summary>
        /// Deletes a leave request by ID.
        /// </summary>
        /// <param name="id">The ID of the leave request to delete.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLeaveRequestAsync(Guid id)
        {
            await _leaveRequestRepository.DeleteLeaveRequestAsync(id);
            return Ok(new { message = "Leave request deleted successfully." });
        }

        /// <summary>
        /// Get user leave balance.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>A leave balance.</returns>
        [HttpGet("balance/{userId}")]
        public async Task<ActionResult<LeaveBalance>> GetLeaveBalance(Guid userId)
        {
            var leaveBalance = await _leaveBalanceRepository.GetLeaveBalanceByUserIdAsync(userId);
            if (leaveBalance == null)
                return NotFound();

            return Ok(leaveBalance);
        }

    }
}
