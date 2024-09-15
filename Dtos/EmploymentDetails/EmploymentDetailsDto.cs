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
        //public string EmploymentStatus { get; set; }
        public Guid TeamId { get; set; }
        public Guid PositionId { get; set; }
    }
}
