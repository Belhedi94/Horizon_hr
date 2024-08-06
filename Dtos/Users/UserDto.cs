namespace Horizon_HR.Dtos.Users
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
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
        public string Cv { get; set; }
        public string ProfileImage { get; set; }
    }
}
