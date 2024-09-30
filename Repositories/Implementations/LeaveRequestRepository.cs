using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.AppDataContext;
using Microsoft.EntityFrameworkCore;
using Horizon_HR.Dtos.LeaveRequest;
using AutoMapper;

namespace Horizon_HR.Repositories.Implementations
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        private readonly DataBaseContext _context;
        private readonly ILogger<LeaveRequestRepository> _logger;
        private readonly IMapper _mapper;

        public LeaveRequestRepository(ILogger<LeaveRequestRepository> logger, DataBaseContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
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

        public async Task<IEnumerable<LeaveRequestDto>> GetAllLeaveRequestsAsync()
        {
            var leaveRequests = await _context.LeaveRequests
                .Include(l => l.User)
                .ToListAsync();

            return _mapper.Map<IEnumerable<LeaveRequestDto>>(leaveRequests);
        }

        public async Task<LeaveRequest> UpdateLeaveRequestAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto)
        {
            var leaveRequest = await _context.LeaveRequests.FirstOrDefaultAsync(l => l.Id == id);
            _mapper.Map(updateLeaveRequestDto, leaveRequest);

            await _context.SaveChangesAsync();

            return leaveRequest;
        }
    }
}
