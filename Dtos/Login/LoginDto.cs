using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.Login
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
