using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.Positions
{
    public class CreatePositionDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
