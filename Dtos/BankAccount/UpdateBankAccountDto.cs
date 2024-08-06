using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.BankAccount
{
    public class UpdateBankAccountDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string BankName { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Iban { get; set; }

        [Required]
        [StringLength(50)]
        public string HolderName { get; set; }
    }
}
