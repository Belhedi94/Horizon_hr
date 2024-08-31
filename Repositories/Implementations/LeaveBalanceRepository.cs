using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Dtos.LeaveBalance;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Repositories.Implementations
{
    public class LeaveBalanceRepository : ILeaveBalanceRepository
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<TeamRepository> _logger;

        public LeaveBalanceRepository(DataBaseContext context, IMapper mapper, ILogger<TeamRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<LeaveBalanceDto> GetLeaveBalanceByUserIdAsync (Guid userId)
        {
            var leaveBalance = await _context.LeaveBalances.FirstOrDefaultAsync(lb => lb.UserId == userId);
            if (leaveBalance == null)
            {
                _logger.LogWarning($"Leave balance for the user_id:  {userId} not found.");
                throw new Exception("Leave balance not found");
            }

            return _mapper.Map<LeaveBalanceDto>(leaveBalance);
        }

        public async Task UpdateLeaveBalanceAsync (UpdateLeaveBalanceDto updateLeaveBalanceDto)
        {
            var leaveBalance = _context.LeaveBalances.FirstOrDefaultAsync(lb => lb.UserId == updateLeaveBalanceDto.UserId);
            if (leaveBalance == null)
                throw new Exception("Leave balance not found");

            _mapper.Map(updateLeaveBalanceDto, leaveBalance);

            await _context.SaveChangesAsync();

        }

    }
}
