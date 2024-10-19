using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.DocumentRequest;

namespace Horizon_HR.Services.Interfaces
{
    public interface IDocumentRequestService
    {
        Task<PagedResult<DocumentRequestDto>> GetAllDocumentRequestsAsync(int pageNumber, int pageSize, string filter, bool usePagination);
        Task<DocumentRequestDto> CreateDocumentRequestAsync(CreateDocumentRequestDto createDocumentRequestDto);
        Task<DocumentRequestDto> GetDocumentRequestByIdAsync(Guid id);
        Task<PagedResult<DocumentRequestDto>> GetDocumentRequestsByUserAsync(Guid userId, int pageNumber, int pageSize,
            string filter, bool usePagination);
        Task<DocumentRequestDto> UpdateDocumentRequestAsync(Guid id, UpdateDocumentRequestDto updateDocumentRequestDto);
        Task DeleteDocumentRequestAsync(Guid id);
    }
}
