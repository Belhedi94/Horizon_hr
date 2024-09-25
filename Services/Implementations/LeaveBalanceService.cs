using AutoMapper;
using Horizon_HR.Dtos.LeaveBalance;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;

namespace Horizon_HR.Services.Implementations
{
    public class LeaveBalanceService : ILeaveBalanceService
    {
        private readonly IMapper _mapper;
        private readonly ILeaveBalanceRepository _leaveBalanceRepository;

        public LeaveBalanceService(IMapper mapper, ILeaveBalanceRepository leaveBalanceRepository)
        {
            _mapper = mapper;
            _leaveBalanceRepository = leaveBalanceRepository;
        }

        public async Task<LeaveBalance> GetLeaveBalanceByUserAsync(Guid userId)
        {
            var leaveBalance = await _leaveBalanceRepository.GetLeaveBalanceByUserAsync(userId);
            return leaveBalance;
        }

        public async Task CreateUserLeaveBalanceAsync(CreateLeaveBalanceDto createLeaveBalanceDto)
        {
            var leaveBalance = _mapper.Map<LeaveBalance>(createLeaveBalanceDto);
            leaveBalance.UpdatedAt = DateTime.Now;
            var createdLeaveBalance = await _leaveBalanceRepository.CreateUserLeaveBalanceAsync(leaveBalance);

        }

    }
}
