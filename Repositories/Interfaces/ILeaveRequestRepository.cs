using Horizon_HR.Dtos.LeaveRequest;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface ILeaveRequestRepository
    {
        Task<IEnumerable<LeaveRequestDto>> GetAllLeaveRequestsAsync();
        Task<LeaveRequestDto> GetLeaveRequestByIdAsync(Guid id);
        Task<IEnumerable<LeaveRequestDto>> GetLeaveRequestsByUserIdAsync(Guid userId);
        Task AddLeaveRequestAsync(CreateLeaveRequestDto createLeaveRequestDto);
        Task UpdateLeaveRequestAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto);
        Task DeleteLeaveRequestAsync(Guid id);
    }
}
