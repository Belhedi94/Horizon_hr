using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.LeaveBalance
{
    public class UpdateLeaveBalanceDto
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public int TotalLeaveDays { get; set; }

        [Required]
        public float UsedLeaveDays { get; set; }
    }
}
