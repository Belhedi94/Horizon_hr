using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Models
{
    public class Department
    {
        [Column("id")]
        [Key]
        public Guid Id { get; set; }

        [Column("name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("description")]
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}
