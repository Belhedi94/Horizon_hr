using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Models
{
    public class PublicHoliday
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; }
    }
}
