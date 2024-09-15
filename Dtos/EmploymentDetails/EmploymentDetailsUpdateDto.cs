using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.EmploymentDetails
{
    public class EmploymentDetailsUpdateDto
    {
        [Required]
        [StringLength(50)]
        public string ContractType { get; set; }

        [Required]
        public DateTime JoiningDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ProbationPeriod { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        [StringLength(50)]
        public string EmploymentType { get; set; }

        public Guid TeamId { get; set; }

        public Guid PositionId { get; set; }
    }
}
