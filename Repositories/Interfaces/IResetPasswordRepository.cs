using Horizon_HR.Dtos.ResetPassword;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface IResetPasswordRepository
    {
        Task<bool> ResetPassword(RequestResetPasswordDto requestResetPasswordDto);
    }
}
