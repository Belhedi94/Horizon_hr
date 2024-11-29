﻿using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.Departments
{
    public class CreateDepartmentDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
