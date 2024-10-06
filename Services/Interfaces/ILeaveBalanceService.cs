using Horizon_HR.Dtos.LeaveBalance;
using Horizon_HR.Models;

namespace Horizon_HR.Services.Interfaces
{
    public interface ILeaveBalanceService
    {
        Task<LeaveBalance> GetLeaveBalanceByUserAsync(Guid userId);
        Task<LeaveBalanceDto> GetLeaveBalanceDtoByUserAsync(Guid userId);
        Task CreateUserLeaveBalanceAsync(CreateLeaveBalanceDto createLeaveBalanceDto);
        Task UpdateLeaveBalanceAsync(Guid id, string type, double actualBalance, double takenDays);
    }
}
