using AutoMapper;
using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;

namespace Horizon_HR.Services.Implementations
{
    public class LeaveRequestService : ILeaveRequestService
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILogger<LeaveRequest> _logger;
        private readonly IMapper _mapper;

        public LeaveRequestService(ILeaveRequestRepository leaveRequestRepository, ILogger<LeaveRequest> logger, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<bool> SubmitLeaveRequestAsync(CreateLeaveRequestDto createLeaveRequestDto)
        {
            var leaveRequest = _mapper.Map<LeaveRequest>(createLeaveRequestDto);
            leaveRequest.UpdatedAt = DateTime.Now;
            _leaveRequestRepository.SubmitLeaveRequestAsync(leaveRequest);

            return true;

            //var startDate = DateTime.Parse(createLeaveRequestDto.StartDate);
            //DateTime? endDate = null;
            //if (!string.IsNullOrEmpty(createLeaveRequestDto.EndDate))
            //    endDate = DateTime.Parse(createLeaveRequestDto.EndDate);

            //var daysTaken = 1;
            //if (endDate.HasValue)
            //    daysTaken = await CalculateLeaveDays(startDate, endDate.Value);

            //return true;
        }


        public async Task<int> CalculateLeaveDays(DateTime startDate, DateTime endDate)
        {
            TimeSpan difference = endDate - startDate;
            int daysBetween = difference.Days;

            return daysBetween;
            
        }

    }
}
