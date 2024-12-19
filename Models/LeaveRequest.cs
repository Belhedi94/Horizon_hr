using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class LeaveRequest
    {
        [Key]
        [Column(Order = 1)]
        public Guid Id { get; set; }

        [Required]
        [Column("user_id", Order = 2)]
        public Guid UserId { get; set; }

        [Required]
        [Column("type", Order = 3)]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [Column("is_half_day", Order = 4)]
        public bool IsHalfDay { get; set; }

        [Required]
        [Column("start_date", Order = 5)]
        public DateTime StartDate { get; set; }

        [Column("end_date", Order = 6)]
        public DateTime? EndDate { get; set; }

        [Column("days_taken", Order = 7)]
        public float DaysTaken { get; set; }

        [Required]
        [Column("reason", Order = 8)]
        public string Reason { get; set; }

        [Required]
        [Column("status", Order = 9)]
        public string Status { get; set; }

        [Required]
        [Column("created_at", Order = 10)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", Order = 11)]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public User User { get; set; }

    }
}
