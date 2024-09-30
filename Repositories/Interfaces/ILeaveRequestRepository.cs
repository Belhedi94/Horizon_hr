﻿using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Models;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface ILeaveRequestRepository
    {
        Task SubmitLeaveRequestAsync(LeaveRequest leaveRequest);
        Task <IEnumerable<LeaveRequest>> GetLeaveRequestsByUserAsync(Guid userId);
        Task <IEnumerable<LeaveRequestDto>> GetAllLeaveRequestsAsync();
        Task<LeaveRequest> UpdateLeaveRequestAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto);
    }
}
