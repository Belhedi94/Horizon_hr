using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class DocumentRequest
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Required]
        [Column("type")]
        public string Type { get; set; }

        [Required]
        [Column("description")]
        public string Description { get; set; }

        [Required]
        [Column("status")]
        public string Status { get; set; }

        [Required]
        [Column("processed_at")]
        public DateTime ProcessedAt { get; set;}

        [Required]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public User User { get; set; }

    }
}
