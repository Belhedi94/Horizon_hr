using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.BankAccount
{
    public class UpdateBankAccountDto
    {
        [StringLength(50)]
        public string? BankName { get; set; }

        [StringLength(50)]
        public string? AccountNumber { get; set; }

        [StringLength(50)]
        public string? Rib { get; set; }

        [StringLength(50)]
        public string? HolderName { get; set; }
    }
}
