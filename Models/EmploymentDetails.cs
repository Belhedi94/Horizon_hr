using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class EmploymentDetails
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("contract_type")]
        [Required]
        [StringLength(50)]
        public string ContractType { get; set; }

        [Column("joining_date")]
        [Required]
        public DateTime JoiningDate { get; set; }

        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [Column("probation_period")]
        [Required]
        [StringLength(50)]
        public string ProbationPeriod { get; set; }

        [Column("employment_status")]
        [Required]
        [StringLength(50)]
        public string EmploymentStatus { get; set; }

        [Column("salary")]
        [Required]
        public decimal Salary { get; set; }

        [Column("employee_type")]
        [Required]
        [StringLength(50)]
        public string EmployeeType { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        [Column("team_id")]
        public Guid TeamId { get; set; }

        public Team Team { get; set; }

        [Column("position_id")]
        public Guid PositionId { get; set; }

        public Position Position { get; set; }
    }
}
