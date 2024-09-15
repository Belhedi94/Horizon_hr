using Horizon_HR.Dtos.BankAccount;
using Horizon_HR.Dtos.EmploymentDetails;
using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.Users
{
    public class UpdateUserDto
    {
        //[Required]
        //public Guid Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [EmailAddress]
        public string PersonalEmail { get; set; }

        [EmailAddress]
        public string ProfessionalEmail { get; set; }

        [Phone]
        public string PersonalPhone { get; set; }

        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long")]
        public string? Password { get; set; }

        [StringLength(20)]
        public string Cin { get; set; }

        [StringLength(20)]
        public string? CnssRegistrationNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(20)]
        public string MaritalStatus { get; set; }

        public IFormFile? ProfileImage { get; set; }

        public EmploymentDetailsUpdateDto EmploymentDetails { get; set; }

        public UpdateBankAccountDto? BankAccount { get; set; }
    }
}
