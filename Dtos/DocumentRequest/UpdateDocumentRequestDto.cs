namespace Horizon_HR.Dtos.DocumentRequest
{
    public class UpdateDocumentRequestDto
    {
        public Guid UserId { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }
    }
}
