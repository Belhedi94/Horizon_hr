﻿using AutoMapper;
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
            var type = createLeaveRequestDto.Type;
            var daysTaken = 0.0;
            var remainingBalance = 0.0;
            var userId = createLeaveRequestDto.UserId;
            var leaveBalance = await _leaveBalanceService.GetLeaveBalanceByUserAsync(userId);
            if (type != "Exceptional")
            {
                var isHalfDay = createLeaveRequestDto.IsHalfDay;
                var startDate = DateTime.Parse(createLeaveRequestDto.StartDate);
                DateTime? endDate = null;
                remainingBalance = type == "Annual" ? leaveBalance.Annual : leaveBalance.Sick;

                if (!string.IsNullOrEmpty(createLeaveRequestDto.EndDate))
                    endDate = DateTime.Parse(createLeaveRequestDto.EndDate);
                if (!isHalfDay)
                {
                    daysTaken = await CalculateLeaveDaysAsync(startDate, endDate);
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
            }
            

            var leaveRequest = _mapper.Map<LeaveRequest>(createLeaveRequestDto);
            leaveRequest.UpdatedAt = DateTime.Now;
            leaveRequest.Status = "Waiting for validation";
            await _leaveRequestRepository.SubmitLeaveRequestAsync(leaveRequest);

            if (type != "Exceptional")
                await _leaveBalanceService.UpdateLeaveBalanceAsync(leaveBalance.Id, type, remainingBalance, daysTaken);


            return Result<LeaveRequest>.Success(leaveRequest);

        }


        public async Task<int> CalculateLeaveDaysAsync(DateTime startDate, DateTime? endDate)
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

        public async Task<Result<IEnumerable<LeaveRequestDto>>> GetLeaveRequestsByUserAsync(Guid userId)
        {
            var leaveRequests = await _leaveRequestRepository.GetLeaveRequestsByUserAsync(userId);
            if (leaveRequests != null && leaveRequests.Any())
            {
                var result = _mapper.Map<IEnumerable<LeaveRequestDto>>(leaveRequests);
                return Result<IEnumerable<LeaveRequestDto>>.Success(result);
            }
            else
                return Result<IEnumerable<LeaveRequestDto>>.Failure("No leave requests saved for this user");


        }

        public async Task<Result<IEnumerable<LeaveRequestDto>>> GetAllLeaveRequestsAsync()
        {
            var leaveRequests = await _leaveRequestRepository.GetAllLeaveRequestsAsync();

            return Result<IEnumerable<LeaveRequestDto>>.Success(leaveRequests);
        }

        public async Task<Result<LeaveRequestDto>> UpdateLeaveRequestAsync(Guid id, UpdateLeaveRequestDto updateLeaveRequestDto)
        {
            var leaveRequest = await _leaveRequestRepository.UpdateLeaveRequestAsync(id, updateLeaveRequestDto);
            var result = _mapper.Map<LeaveRequestDto>(leaveRequest);
            
            return Result<LeaveRequestDto>.Success(result);

        }
    }
}
