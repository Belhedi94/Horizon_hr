using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class LeaveBalance
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Required]
        [Column("total_leave_days")]
        public int TotalLeaveDays { get; set; }

        [Required]
        [Column("used_leave_days")]
        public float UsedLeaveDays { get; set; }

        [Required]
        [Column("remaining_leave_days")]
        public float RemainingLeaveDays => TotalLeaveDays - UsedLeaveDays;

        public User User { get; set; }
    }
}
