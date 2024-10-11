using Horizon_HR.Dtos.BankAccount;

namespace Horizon_HR.Services.Interfaces
{
    public interface IBankAccountService
    {
        Task<BankAccountDto> CreateBankAccountAsync(CreateBankAccountDto createBankAccountDto);
        Task<BankAccountDto> GetBankAccountByIdAsync(Guid bankAccountId);
        Task DeleteBankAccountAsync(Guid bankAccountId);
    }
}
