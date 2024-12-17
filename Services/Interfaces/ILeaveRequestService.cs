using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Models;
using Horizon_HR.Services.Common;

namespace Horizon_HR.Services.Interfaces
{
    public interface ILeaveRequestService
    {
        Task<PagedResult<LeaveRequestDto>> GetAllLeaveRequestsAsync(int pageNumber, int pageSize,
            string filter, bool usePagination, bool forDashboard);
        Task<Result<LeaveRequest>> SubmitLeaveRequestAsync(CreateLeaveRequestDto createLeaveRequestDto);
        Task<int> CalculateLeaveDaysAsync(DateTime startDate, DateTime? endDate);
        Task<Result<IEnumerable<LeaveRequestDto>>> GetLeaveRequestsByUserAsync(Guid userId);
        Task<Result<LeaveRequestDto>> GetLeaveRequestByIdAsync(Guid id);
        Task<Result<LeaveRequestDto>> UpdateLeaveRequestAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto);
    }
}
