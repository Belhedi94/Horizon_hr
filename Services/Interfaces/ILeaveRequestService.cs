using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Models;
using Horizon_HR.Services.Common;

namespace Horizon_HR.Services.Interfaces
{
    public interface ILeaveRequestService
    {
        Task<Result<LeaveRequest>>SubmitLeaveRequestAsync(CreateLeaveRequestDto createLeaveRequestDto);
        Task<int> CalculateLeaveDaysAsync(DateTime startDate, DateTime? endDate);
        Task<Result<IEnumerable<LeaveRequestDto>>> GetLeaveRequestsByUserAsync(Guid userId);
        Task<Result<IEnumerable<LeaveRequestDto>>> GetAllLeaveRequestsAsync();
        Task<Result<LeaveRequestDto>> UpdateLeaveRequestAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto);
    }
}
