using Horizon_HR.Models;
using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.Users
{
    public class UpdateUserDto
    {
        [Required]
        public Guid Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [EmailAddress]
        public string PersonalEmail { get; set; }

        [EmailAddress]
        public string ProfessionalEmail { get; set; }

        [Phone]
        public string PersonalPhone { get; set; }

        [StringLength(100, MinimumLength =8)]
        public string Password { get; set; }

        [StringLength(20)]
        public string Cin { get; set; }

        [StringLength(50)]
        public string Role { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(20)]
        public string MaritalStatus { get; set; }

        public IFormFile? Cv { get; set; }

        public IFormFile? ProfileImage { get; set; }

        //public EmploymentDetails EmploymentDetails { get; set; }
    }
}
