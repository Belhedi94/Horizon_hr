using Horizon_HR.Models;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface IBankAccountRepository
    {
        Task<BankAccount> CreateBankAccountAsync(BankAccount bankAccount);
    }
}
