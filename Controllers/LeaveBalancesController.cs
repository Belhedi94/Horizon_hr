using Horizon_HR.Dtos.ApiResponse;
using Horizon_HR.Dtos.LeaveBalance;
using Horizon_HR.Models;
using Horizon_HR.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [ApiController]
    [Route("/api/leaves/balances/")]
    public class LeaveBalancesController : ControllerBase
    {
        private readonly ILeaveBalanceService _leaveBalanceService;

        public LeaveBalancesController(ILeaveBalanceService leaveBalanceService)
        {
            _leaveBalanceService = leaveBalanceService;
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetLeaveBalanceDtoByUserAsync(Guid userId)
        {
            var leaveBalance = await _leaveBalanceService.GetLeaveBalanceDtoByUserAsync(userId);

            return Ok(new ApiResponse<LeaveBalanceDto>
            {
                Status = 200,
                Message = "Leave balance retrieved successfully",
                Data = leaveBalance
            });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLeaveBalanceByIdAsync(Guid id)
        {
            var leaveBalance = await _leaveBalanceService.GetLeaveBalanceByIdAsync(id);

            return Ok(new ApiResponse<LeaveBalance>
            {
                Status = 200,
                Message = "Leave balance retrieved successfully",
                Data = leaveBalance
            });
        }
    }
}
