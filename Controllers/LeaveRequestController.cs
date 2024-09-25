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
                return Ok(result.Data);
            else
                return BadRequest(result.ErrorMessage);
        }
    }
}
