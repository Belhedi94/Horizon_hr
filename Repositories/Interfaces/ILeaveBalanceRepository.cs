using Horizon_HR.Dtos.LeaveBalance;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface ILeaveBalanceRepository
    {
        Task<LeaveBalanceDto> GetLeaveBalanceByUserIdAsync(Guid userId);
        Task UpdateLeaveBalanceAsync (UpdateLeaveBalanceDto updateLeaveBalanceDto);
    }
}
