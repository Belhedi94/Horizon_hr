﻿using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Contracts.Positions
{
    public class UpdatePositionDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
