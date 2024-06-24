using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.Positions
{
    public class UpdatePositionDto
    {
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
