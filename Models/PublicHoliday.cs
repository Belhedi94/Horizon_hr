using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon_HR.Models
{
    public class PublicHoliday
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("date")]
        public DateTime Date { get; set; }

        [Required]
        [Column("description")]
        public string Description { get; set; }
    }
}
