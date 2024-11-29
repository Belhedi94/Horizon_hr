using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.Positions
{
    public class CreatePositionDto
    {
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
