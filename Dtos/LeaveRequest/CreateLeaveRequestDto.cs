using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.LeaveRequest
{
    public class CreateLeaveRequestDto
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string StartDate { get; set; }

        public string? EndDate { get; set; }

        [Required]
        public bool IsHalfDay { get; set; }

        [Required]
        public string Reason { get; set; }
    }
}
