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

        public async Task<LeaveBalance> GetLeaveBalanceByIdAsync(Guid id)
        {
            return await _leaveBalanceRepository.GetLeaveBalanceByIdAsync(id);
        }

        public async Task<LeaveBalanceDto> GetLeaveBalanceDtoByUserAsync(Guid userId)
        {
            var leaveBalance = await _leaveBalanceRepository.GetLeaveBalanceByUserAsync(userId);

            return _mapper.Map<LeaveBalanceDto>(leaveBalance);
        }

        public async Task CreateUserLeaveBalanceAsync(CreateLeaveBalanceDto createLeaveBalanceDto)
        {
            var leaveBalance = _mapper.Map<LeaveBalance>(createLeaveBalanceDto);
            leaveBalance.UpdatedAt = DateTime.Now;
            var createdLeaveBalance = await _leaveBalanceRepository.CreateUserLeaveBalanceAsync(leaveBalance);

        }

        public async Task UpdateLeaveBalanceAsync(Guid id, string type, double takenDays)
        {
            var leaveBalance = await _leaveBalanceRepository.GetLeaveBalanceByIdAsync(id);
            var updateLeaveBalanceDto = _mapper.Map<UpdateLeaveBalanceDto>(leaveBalance);
            if (type == "Annual")
                updateLeaveBalanceDto.Annual -= takenDays;
            else
                updateLeaveBalanceDto.Sick -= takenDays;

            updateLeaveBalanceDto.UpdatedAt = DateTime.Now;

            await _leaveBalanceRepository.UpdateLeaveBalanceAsync(id, updateLeaveBalanceDto);
        }

    }
}
