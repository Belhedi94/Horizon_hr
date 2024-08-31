﻿using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.LeaveRequest
{
    public class UpdateLeaveRequestDto
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Reason { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }
    }
}