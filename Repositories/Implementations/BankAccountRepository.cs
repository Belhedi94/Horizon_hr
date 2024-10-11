using Horizon_HR.AppDataContext;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;

namespace Horizon_HR.Repositories.Implementations
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly DataBaseContext _context;
        private readonly ILogger<BankAccountRepository> _logger;

        public BankAccountRepository(DataBaseContext context, ILogger<BankAccountRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<BankAccount> CreateBankAccountAsync(BankAccount bankAccount)
        {
            await _context.BankAccounts.AddAsync(bankAccount);
            await _context.SaveChangesAsync();

            return bankAccount;
        }

        public async Task<BankAccount> GetBankAccountByIdAsync(Guid id)
        {
            var bankAccount = await _context.BankAccounts.FindAsync(id);

            return bankAccount;
        }

        public async Task DeleteBankAccountAsync(Guid id)
        {
            var bankAccount = await _context.BankAccounts.FindAsync(id);

            if (bankAccount == null)
            {
                _logger.LogWarning($"Position with ID {id} not found.");
                throw new Exception("Position not found");
            }

            _context.BankAccounts.Remove(bankAccount);

            await _context.SaveChangesAsync();
        }
    }
}
