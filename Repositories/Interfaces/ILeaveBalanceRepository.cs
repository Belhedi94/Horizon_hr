using Horizon_HR.Dtos.LeaveBalance;
using Horizon_HR.Models;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface ILeaveBalanceRepository
    {
        Task<LeaveBalance> CreateUserLeaveBalanceAsync(LeaveBalance leaveBalance);
    }
}
