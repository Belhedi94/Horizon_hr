using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.ResetPassword
{
    public class RequestResetPasswordDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string NewPassword { get; set; }
    }
}
