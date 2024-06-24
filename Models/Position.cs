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
        [StringLength(50)]
        public string Description { get; set; }

        public ICollection<EmploymentDetails> EmploymentsDetails { get; set; }
    }
}
