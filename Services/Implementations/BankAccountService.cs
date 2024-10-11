using AutoMapper;
using Horizon_HR.Dtos.BankAccount;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;

namespace Horizon_HR.Services.Implementations
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository _bankAccountRepository;
        private readonly ILogger<BankAccountService> _logger;
        private readonly IMapper _mapper;

        public BankAccountService (IBankAccountRepository bankAccountRepository, IMapper mapper, ILogger<BankAccountService> logger)
        {
            _bankAccountRepository = bankAccountRepository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<BankAccountDto> CreateBankAccountAsync(CreateBankAccountDto createBankAccountDto)
        {
            var bankAccount = _mapper.Map<BankAccount>(createBankAccountDto);
            var result = await _bankAccountRepository.CreateBankAccountAsync(bankAccount);

            return _mapper.Map<BankAccountDto>(result);
        }

        public async Task<BankAccountDto> GetBankAccountByIdAsync(Guid id)
        {
            var bankAccount = await _bankAccountRepository.GetBankAccountByIdAsync(id);

            return _mapper.Map<BankAccountDto>(bankAccount);
        }

        public async Task DeleteBankAccountAsync(Guid id)
        {
            await _bankAccountRepository.DeleteBankAccountAsync(id);
        }
    }
}
