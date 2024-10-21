namespace Horizon_HR.Dtos.JobOffer
{
    public class JobOfferDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public string EmploymentType { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
