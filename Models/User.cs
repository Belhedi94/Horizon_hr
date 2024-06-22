using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum MaritalStatus
    {
        Single,
        Married
    }

    public class User
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("first_name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Column("last_name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Column("personal_email")]
        [Required]
        [EmailAddress]
        public string PersonalEmail { get; set; }

        [Column("professional_email")]
        [Required]
        [EmailAddress]
        public string ProfessionalEmail { get; set; }

        [Column("password")]
        [Required]
        public byte[] Password { get; set; }

        [Column("password_salt")]
        [Required]
        public byte[] PasswordSalt { get; set; }

        [Column("personal_phone")]
        [Required]
        [Phone]
        public string PersonalPhone { get; set; }

        [Column("cin")]
        [Required]
        [StringLength(20)]
        public string Cin { get; set; }

        [Column("role")]
        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        [Column("date_of_birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Column("address")]
        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Column("gender")]
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Column("marital_status")]
        [Required]
        [StringLength(20)]
        public string MaritalStatus { get; set; }

        [Column("cv")]
        [StringLength(255)]
        public string Cv { get; set; }

        [Column("profile_image")]
        [StringLength(255)]
        public string ProfileImage { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public EmploymentDetails EmploymentDetails { get; set; }

    }
}
