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
            var userId = createLeaveRequestDto.UserId;
            var daysTaken = 0.0;
            
            var leaveBalance = await _leaveBalanceService.GetLeaveBalanceByUserAsync(userId);
            var isHalfDay = createLeaveRequestDto.IsHalfDay;
            var startDate = DateTime.Parse(createLeaveRequestDto.StartDate);
            DateTime? endDate = null;

            if (!string.IsNullOrEmpty(createLeaveRequestDto.EndDate))
                endDate = DateTime.Parse(createLeaveRequestDto.EndDate);
            if (!isHalfDay)
            {
                daysTaken = await CalculateLeaveDays(startDate, endDate);
                var remainingBalance = createLeaveRequestDto.Type == "Annual" ? leaveBalance.Annual : leaveBalance.Sick;
                if (daysTaken > remainingBalance)
                    return Result<LeaveRequest>.Failure("Insufficient leave balance");
            }
            else
            {
                if (endDate != null)
                    return Result<LeaveRequest>.Failure("Date range is not acceptable for half days type");

                var publicHoliday = await _publicHolidaysService.GetPublicHolidaysBetweenGivenDaysAsync(startDate, null);
                if (!publicHoliday.Any() && DayOfWeek.Saturday != startDate.DayOfWeek && DayOfWeek.Sunday != startDate.DayOfWeek)
                    daysTaken = 0.5;

            }

            if (daysTaken == 0.0)
                return Result<LeaveRequest>.Failure("Please verify your selection, you can't choose a date which corresponds to public holiday/weekend");

            var leaveRequest = _mapper.Map<LeaveRequest>(createLeaveRequestDto);
            leaveRequest.UpdatedAt = DateTime.Now;
            await _leaveRequestRepository.SubmitLeaveRequestAsync(leaveRequest);

            return Result<LeaveRequest>.Success(leaveRequest);

        }


        public async Task<int> CalculateLeaveDays(DateTime startDate, DateTime? endDate)
        {
            var publicHolidays = await _publicHolidaysService.GetPublicHolidaysBetweenGivenDaysAsync(startDate, endDate);
            int validLeaveDays = 0;
            if (endDate.HasValue)
            {
                for (var date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                        continue;

                    if (publicHolidays.Contains(date))
                        continue;

                    validLeaveDays++;
                }
            }
            else
            {
                if(!publicHolidays.Any() && startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                    validLeaveDays = 1;
            }
            
            return validLeaveDays;

        }

    }
}
