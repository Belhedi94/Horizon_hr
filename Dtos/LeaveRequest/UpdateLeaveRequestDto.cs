using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.LeaveRequest
{
    public class UpdateLeaveRequestDto
    {
        [Required]
        public LeaveType Type { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public bool IsHalfDay { get; set; }

        [Required]
        public string Reason { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
