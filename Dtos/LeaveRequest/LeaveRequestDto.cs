using Horizon_HR.Dtos.Users;

namespace Horizon_HR.Dtos.LeaveRequest
{
    public class LeaveRequestDto
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Type { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public float DaysTaken { get; set; }

        public bool IsHalfDay { get; set; }

        public string Reason { get; set; }

        public string Status { get; set; }

        public float Period { get; set; }

        public DateTime CreatedAt { get; set; }

        public UserDto User { get; set; }
    }
}
