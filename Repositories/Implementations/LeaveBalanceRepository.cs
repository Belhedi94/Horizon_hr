using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Dtos.LeaveBalance;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Repositories.Implementations
{
    public class LeaveBalanceRepository : ILeaveBalanceRepository
    {
        private readonly DataBaseContext _context;
        private readonly ILogger<LeaveBalanceRepository> _logger;
        private readonly IMapper _mapper;

        public LeaveBalanceRepository(DataBaseContext context, ILogger<LeaveBalanceRepository> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
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

        public async Task<LeaveBalance> GetLeaveBalanceByIdAsync(Guid id)
        {
            return await _context.LeaveBalances.FindAsync(id);
        }


        public async Task UpdateLeaveBalanceAsync(Guid id, UpdateLeaveBalanceDto updatedLeaveBalanceDto)
        {
            var leaveBalance = await _context.LeaveBalances.FindAsync(id);

            if (!updatedLeaveBalanceDto.Annual.HasValue)
                updatedLeaveBalanceDto.Annual = leaveBalance.Annual;

            if (!updatedLeaveBalanceDto.Sick.HasValue)
                updatedLeaveBalanceDto.Sick = leaveBalance.Sick;

            _mapper.Map(updatedLeaveBalanceDto, leaveBalance);

            await _context.SaveChangesAsync();
            
        }
    }
}
