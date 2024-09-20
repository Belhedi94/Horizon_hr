using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Models
{
    public class PublicHoliday
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
