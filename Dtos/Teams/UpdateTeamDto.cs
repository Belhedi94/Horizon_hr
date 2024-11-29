using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.Teams
{
    public class UpdateTeamDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid DepartmentId { get; set; }
    }
}
