namespace Horizon_HR.Dtos.DocumentRequest
{
    public class UpdateDocumentRequestDto
    {
        public string? Type { get; set; }

        public string? Description { get; set; }

        public string Status { get; set; }

        public DateTime ProcessedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
