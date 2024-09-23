using Horizon_HR.Dtos.LeaveRequest;

namespace Horizon_HR.Services.Interfaces
{
    public interface ILeaveRequestService
    {
        Task<bool> SubmitLeaveRequestAsync(CreateLeaveRequestDto createLeaveRequestDto);
        Task<int> CalculateLeaveDays(DateTime startDate, DateTime endDate);
    }
}
