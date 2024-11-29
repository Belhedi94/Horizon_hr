using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class BankAccount
    {
        [Key]
        public Guid Id { get; set; }

        [Column("bank_name")]
        [StringLength(50)]
        public string BankName { get; set; }

        [Column("account_number")]
        [StringLength(50)]
        public string AccountNumber { get; set; }

        [Column("rib")]
        [StringLength(50)]
        public string Rib { get; set; }

        [Column("holder_name")]
        [StringLength(50)]
        public string HolderName { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }

        public User User { get; set; }
    }
}
