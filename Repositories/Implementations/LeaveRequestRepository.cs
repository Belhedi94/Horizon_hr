using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.AppDataContext;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Repositories.Implementations
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        private readonly DataBaseContext _context;
        private readonly ILogger<LeaveRequestRepository> _logger;

        public LeaveRequestRepository(ILogger<LeaveRequestRepository> logger, DataBaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task SubmitLeaveRequestAsync(LeaveRequest leaveRequest)
        {
            try
            {
                _context.LeaveRequests.Add(leaveRequest);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while creating the leave request");
                throw;
            }
            
        }

        public async Task<IEnumerable<LeaveRequest>> GetLeaveRequestsByUserAsync(Guid userId)
        {
            var leaveRequest = await _context.LeaveRequests
                .Where(l => l.UserId == userId)
                .ToListAsync();

            return leaveRequest;
        }

    }
}
