using System.ComponentModel.DataAnnotations;

namespace Horizon_HR.Dtos.DocumentRequest
{
    public class CreateDocumentRequestDto
    {
        public Guid UserId { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Status { get; set; } = "Pending";
    }
}
