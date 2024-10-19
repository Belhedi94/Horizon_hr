using Horizon_HR.Dtos.Users;

namespace Horizon_HR.Dtos.DocumentRequest
{
    public class DocumentRequestDto
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime ProcessedAt { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; }

        public UserDto User { get; set; }
    }
}
