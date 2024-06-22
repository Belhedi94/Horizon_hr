using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class EmploymentDetails
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

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


        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
