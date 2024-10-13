﻿using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Models;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface ILeaveRequestRepository
    {
        Task<PagedResult<LeaveRequest>> GetAllLeaveRequestsAsync(int pageNumber, int pageSize, string filter, bool usePagintion = true);
        Task SubmitLeaveRequestAsync(LeaveRequest leaveRequest);
        Task <IEnumerable<LeaveRequest>> GetLeaveRequestsByUserAsync(Guid userId);
        Task<LeaveRequest> UpdateLeaveRequestAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto);
    }
}
