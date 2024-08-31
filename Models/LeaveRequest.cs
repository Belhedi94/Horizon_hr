using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class LeaveRequest
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Required]
        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Column("reason")]
        public string Reason { get; set; }

        [Required]
        [Column("status")]
        public string Status { get; set; }

        public User User { get; set; }
    }
}
