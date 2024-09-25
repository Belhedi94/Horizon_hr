using AutoMapper;
using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Common;
using Horizon_HR.Services.Interfaces;

namespace Horizon_HR.Services.Implementations
{
    public class LeaveRequestService : ILeaveRequestService
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveBalanceService _leaveBalanceService;
        private readonly IPublicHolidaysService _publicHolidaysService;
        private readonly ILogger<LeaveRequest> _logger;
        private readonly IMapper _mapper;

        public LeaveRequestService(ILeaveRequestRepository leaveRequestRepository,
            ILogger<LeaveRequest> logger, IMapper mapper, ILeaveBalanceService leaveBalanceService, IPublicHolidaysService publicHolidaysService)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _leaveBalanceService = leaveBalanceService;
            _publicHolidaysService = publicHolidaysService;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<LeaveRequest>> SubmitLeaveRequestAsync(CreateLeaveRequestDto createLeaveRequestDto)
        {
            var leaveType = createLeaveRequestDto.Type;
            var userId = createLeaveRequestDto.UserId;
            if (leaveType == "Annual")
            {
                var leaveBalance = await _leaveBalanceService.GetLeaveBalanceByUserAsync(userId);
                var isHalfDay = createLeaveRequestDto.IsHalfDay;

                if (!isHalfDay)
                {
                    var startDate = DateTime.Parse(createLeaveRequestDto.StartDate);
                    DateTime? endDate = null;
                    if (!string.IsNullOrEmpty(createLeaveRequestDto.EndDate))
                        endDate = DateTime.Parse(createLeaveRequestDto.EndDate);

                    //var daysTaken = endDate.HasValue ? await CalculateLeaveDays(startDate, endDate.Value) : 1;

                    var daysTaken = await CalculateLeaveDays(startDate, endDate);
                    if (daysTaken > leaveBalance.Annual)
                        return Result<LeaveRequest>.Failure("Insufficient leave balance");
                }
            }

            var leaveRequest = _mapper.Map<LeaveRequest>(createLeaveRequestDto);
            leaveRequest.UpdatedAt = DateTime.Now;
            await _leaveRequestRepository.SubmitLeaveRequestAsync(leaveRequest);

            return Result<LeaveRequest>.Success(leaveRequest);

        }


        public async Task<int> CalculateLeaveDays(DateTime startDate, DateTime? endDate)
        {
            //TimeSpan difference = endDate - startDate;
            //int daysBetween = difference.Days;

            //return daysBetween;

            var publicHolidays = await _publicHolidaysService.GetPublicHolidaysBetweenGivenDaysAsync(startDate, endDate);

            int validLeaveDays = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    continue;

                if (publicHolidays.Contains(date))
                    continue;

                validLeaveDays++;
            }

            return validLeaveDays;

        }

    }
}
