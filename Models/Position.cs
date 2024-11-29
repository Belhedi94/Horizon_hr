using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class Position
    {
        [Column("id")]
        [Key]
        public Guid Id { get; set; }

        [Column("title")]
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Column("description")]
        [Required]
        public string Description { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }

        public ICollection<EmploymentDetails> EmploymentsDetails { get; set; }
    }
}
