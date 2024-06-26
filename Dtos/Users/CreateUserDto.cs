using Horizon_HR.Dtos.BankAccount;
using Horizon_HR.Dtos.EmploymentDetails;
using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.Users
{
    public class CreateUserDto
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string PersonalEmail { get; set; }

        [Required]
        [EmailAddress]
        public string ProfessionalEmail { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [Phone]
        public string PersonalPhone { get; set; }

        [Required]
        [StringLength(20)]
        public string Cin { get; set; }

        [StringLength(20)]
        public string CnssRegsitrationNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [StringLength(20)]
        public string MaritalStatus { get; set; }

        public IFormFile? Cv { get; set; }

        public IFormFile? ProfileImage { get; set; }

        public EmploymentDetailsCreationDto EmploymentDetails { get; set; }

        public CreateBankAccountDto BankAccount { get; set; }
    }
}
