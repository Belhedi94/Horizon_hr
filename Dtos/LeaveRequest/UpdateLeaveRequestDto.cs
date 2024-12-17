namespace Horizon_HR.Dtos.LeaveRequest
{
    public class UpdateLeaveRequestDto
    {
        public string? Type { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsHalfDay { get; set; }

        public float DaysTaken { get; set; }

        public string? Reason { get; set; }

        public string Status { get; set; }
    }
}
