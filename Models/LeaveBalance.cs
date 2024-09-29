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

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
