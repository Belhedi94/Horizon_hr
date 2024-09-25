using Horizon_HR.AppDataContext;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Repositories.Implementations
{
    public class LeaveBalanceRepository : ILeaveBalanceRepository
    {
        private readonly DataBaseContext _context;
        private readonly ILogger<LeaveBalanceRepository> _logger;

        public LeaveBalanceRepository(DataBaseContext context, ILogger<LeaveBalanceRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<LeaveBalance> CreateUserLeaveBalanceAsync(LeaveBalance leaveBalance)
        {
            try
            {
                _context.LeaveBalances.Add(leaveBalance);

                await _context.SaveChangesAsync();

                return leaveBalance;
            } 
            catch(Exception ex)
            {
                _logger.LogError(ex, "An error occured while creating the leave balance");
                throw;
                
            }
        }

        public async Task<LeaveBalance> GetLeaveBalanceByUserAsync(Guid userId)
        {
            var leaveBalance = await _context.LeaveBalances.FirstOrDefaultAsync(l => l.UserId == userId);
            return leaveBalance;
        }

    }
}
