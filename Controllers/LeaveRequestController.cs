using Horizon_HR.Dtos.LeaveRequest;
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

        [HttpGet]
        public async Task<IActionResult> GetAllLeaveRequestsAsync()
        {
            var result = await _leaveRequestService.GetAllLeaveRequestsAsync();

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
