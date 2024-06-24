using Horizon_HR.Dtos.Departments;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class Team
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

        public Guid DepartmentId { get; set; }
        public DepartmentDto Department { get; set; }
    }
}
