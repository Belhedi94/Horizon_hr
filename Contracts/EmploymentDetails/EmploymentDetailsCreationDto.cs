using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Contracts.EmploymentDetails
{
    public class EmploymentDetailsCreationDto
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
        [StringLength(50)]
        public string EmploymentStatus { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeType { get; set; }
    }
}
