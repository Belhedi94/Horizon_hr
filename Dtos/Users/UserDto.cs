using Horizon_HR.Dtos.BankAccount;
using Horizon_HR.Dtos.EmploymentDetails;
using Horizon_HR.Dtos.LeaveBalance;

namespace Horizon_HR.Dtos.Users

{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
        public string PersonalEmail { get; set; }
        public string ProfessionalEmail { get; set; }
        public string PersonalPhone { get; set; }
        public string Cin { get; set; }
        public string CnssRegistrationNumber { get; set; }
        public string Role { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string ProfileImage { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiration { get; set; }
        public EmploymentDetailsDto EmploymentDetails { get; set; }
        public BankAccountDto BankAccount { get; set; }
        public LeaveBalanceDto LeaveBalance { get; set; }
    }
}
