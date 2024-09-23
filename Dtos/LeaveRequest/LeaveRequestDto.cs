﻿namespace Horizon_HR.Dtos.LeaveRequest
{
    public class LeaveRequestDto
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public LeaveType Type { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsHalfDay { get; set; }

        public string Reason { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}