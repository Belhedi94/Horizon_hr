using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Models;
using Horizon_HR.Services.Common;

namespace Horizon_HR.Services.Interfaces
{
    public interface ILeaveRequestService
    {
        Task<Result<LeaveRequest>>SubmitLeaveRequestAsync(CreateLeaveRequestDto createLeaveRequestDto);
        Task<int> CalculateLeaveDays(DateTime startDate, DateTime endDate);
    }
}
