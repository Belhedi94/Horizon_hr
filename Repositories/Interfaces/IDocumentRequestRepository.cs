using Horizon_HR.Dtos.DocumentRequest;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Models;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface IDocumentRequestRepository
    {
        Task<PagedResult<DocumentRequest>> GetAllDocumentRequestsAsync(int pageNumber, int pageSize, string filter, bool usePagintion = true);
        Task<DocumentRequest> CreateDocumentRequestAsync(DocumentRequest documentRequest);
        Task<DocumentRequest> GetDocumentRequestByIdAsync(Guid id);
        Task<PagedResult<DocumentRequest>> GetDocumentRequestsByUserAsync(Guid userId, int pageNumber, int pageSize,
            string filter, bool usePagination);
        Task<DocumentRequest> UpdateDocumentRequestAsync(Guid id, UpdateDocumentRequestDto updateDocumentRequestDto);
        Task DeleteDocumentRequestAsync(Guid id);
    }
}
