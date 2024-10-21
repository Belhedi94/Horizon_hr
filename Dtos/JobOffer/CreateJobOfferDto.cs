using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.JobOffer
{
    public class CreateJobOfferDto
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string EmploymentType { get; set; }

        [Required]
        public string Status { get; set; }

    }
}
