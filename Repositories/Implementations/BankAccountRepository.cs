using Horizon_HR.AppDataContext;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;

namespace Horizon_HR.Repositories.Implementations
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly DataBaseContext _context;

        public BankAccountRepository(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<BankAccount> CreateBankAccountAsync(BankAccount bankAccount)
        {
            await _context.BankAccounts.AddAsync(bankAccount);
            await _context.SaveChangesAsync();

            return bankAccount;
        }
    }
}
