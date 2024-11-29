using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class LeaveBalance
    {
        [Key]
        public Guid Id { get; set; }

        [Column("annual")]
        public double Annual { get; set; }

        [Column("sick")]
        public double Sick { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public User User { get; set; }
    }
}
