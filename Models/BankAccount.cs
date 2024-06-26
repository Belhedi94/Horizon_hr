using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class BankAccount
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column("bank_name")]
        [StringLength(50)]
        public string BankName { get; set; }

        [Required]
        [Column("account_number")]
        [StringLength(50)]
        public string AccountNumber { get; set; }

        [Required]
        [Column("iban")]
        [StringLength(50)]
        public string Iban { get; set; }

        [Required]
        [Column("holder_name")]
        [StringLength(50)]
        public string HolderName { get; set; }

        public User User { get; set; }
    }
}
