using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Repositories.Implementations
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<TeamRepository> _logger;

        public LeaveRequestRepository(DataBaseContext context, IMapper mapper, ILogger<TeamRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }
        
        public async Task<IEnumerable<LeaveRequestDto>> GetAllLeaveRequestsAsync()
        {
            var leaveRequests = await _context.LeaveRequests.ToListAsync();
            return _mapper.Map<IEnumerable<LeaveRequestDto>>(leaveRequests);
        }

        public async Task<LeaveRequestDto> GetLeaveRequestByIdAsync(Guid id)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest == null)
            {
                _logger.LogWarning($"Leave request with ID {id} not found.");
                throw new Exception("Leave request not found");
            }

            return _mapper.Map<LeaveRequestDto>(leaveRequest);
        }

        public async Task<IEnumerable<LeaveRequestDto>> GetLeaveRequestsByUserIdAsync(Guid userId)
        {
            var leaveRequests = await _context.LeaveRequests.Where(lr => lr.UserId == userId).ToListAsync();

            return _mapper.Map<IEnumerable<LeaveRequestDto>>(leaveRequests);
        }

        public async Task AddLeaveRequestAsync(CreateLeaveRequestDto createLeaveRequestDto)
        {

            var leaveRequest = _mapper.Map<LeaveRequest>(createLeaveRequestDto);
            _context.Add(leaveRequest);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLeaveRequestAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest == null)
                throw new Exception("Leave request not found");

            _mapper.Map(updateLeaveRequestDto, leaveRequest);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteLeaveRequestAsync(Guid id)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest == null)
            {
                _logger.LogWarning($"Leave request with ID {id} not found.");
                throw new Exception("Leave request not found");
            }

            _context.LeaveRequests.Remove(leaveRequest);

            await _context.SaveChangesAsync();
        }
    }
}
