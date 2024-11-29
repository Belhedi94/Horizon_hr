using Horizon_HR.Dtos.Positions;
using Horizon_HR.Dtos.Teams;

namespace Horizon_HR.Dtos.EmploymentDetails
{
    public class EmploymentDetailsDto
    {
        public string ContractType { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ProbationPeriod { get; set; }
        public decimal Salary { get; set; }
        public string EmploymentType { get; set; }
        public TeamDto Team { get; set; }
        public PositionDto Position { get; set; }
    }
}
