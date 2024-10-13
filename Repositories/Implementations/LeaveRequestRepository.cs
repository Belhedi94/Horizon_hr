using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.AppDataContext;
using Microsoft.EntityFrameworkCore;
using Horizon_HR.Dtos.LeaveRequest;
using AutoMapper;
using Horizon_HR.Dtos.PagedResult;

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

        public async Task<PagedResult<LeaveRequest>> GetAllLeaveRequestsAsync(int pageNumber, int pageSize, string filter, bool usePagination)
        {
            var query = _context.LeaveRequests.AsQueryable();

            if (!string.IsNullOrEmpty(filter))
                query = query.Where(l => l.Type.Contains(filter) || l.Reason.Contains(filter) || l.Status.Contains(filter));

            var totalCount = await query.CountAsync();

            if (usePagination)
            {
                query = query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
            }

            var leaveRequests = await query
                .Include(l => l.User)
                    .ThenInclude(u => u.LeaveBalance)
                .ToListAsync();

            return new PagedResult<LeaveRequest>
            {
                Items = leaveRequests,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
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

        public async Task<LeaveRequest> UpdateLeaveRequestAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto)
        {
            var leaveRequest = await _context.LeaveRequests.FirstOrDefaultAsync(l => l.Id == id);
            _mapper.Map(updateLeaveRequestDto, leaveRequest);

            await _context.SaveChangesAsync();

            return leaveRequest;
        }
    }
}
