using AutoMapper;
using Horizon_HR.Dtos.DocumentRequest;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;
using Horizon_HR.Models;
using Horizon_HR.Dtos.PagedResult;

namespace Horizon_HR.Services.Implementations
{
    public class DocumentRequestService : IDocumentRequestService
    {
        private readonly IDocumentRequestRepository _documentRequestRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<DocumentRequestService> _logger;

        public DocumentRequestService(IDocumentRequestRepository documentRequestRepository, IMapper mapper, ILogger<DocumentRequestService> logger)
        {
            _documentRequestRepository = documentRequestRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PagedResult<DocumentRequestDto>> GetAllDocumentRequestsAsync(int pageNumber, int pageSize, string filter,
            bool usePagintion)
        {
            var pagedDocumentRequests = await _documentRequestRepository.GetAllDocumentRequestsAsync(pageNumber, pageSize, filter, usePagintion);
            var pagedDocumentRequestsDto = new PagedResult<DocumentRequestDto>
            {
                Items = _mapper.Map<IEnumerable<DocumentRequestDto>>(pagedDocumentRequests.Items),
                TotalItems = pagedDocumentRequests.TotalItems,
                PageNumber = pagedDocumentRequests.PageNumber,
                PageSize = pagedDocumentRequests.PageSize
            };

            return pagedDocumentRequestsDto;

        }

        public async Task<DocumentRequestDto> CreateDocumentRequestAsync(CreateDocumentRequestDto createDocumentRequestDto)
        {
            var documentRequest = _mapper.Map<DocumentRequest>(createDocumentRequestDto);
            var newDocumentRequest = await _documentRequestRepository.CreateDocumentRequestAsync(documentRequest);

            return _mapper.Map<DocumentRequestDto>(newDocumentRequest);
        }

        public async Task<DocumentRequestDto> GetDocumentRequestByIdAsync(Guid id)
        {
            var documentRequest = await _documentRequestRepository.GetDocumentRequestByIdAsync(id);

            return _mapper.Map<DocumentRequestDto>(documentRequest);
        }

        public async Task<DocumentRequestDto> UpdateDocumentRequestAsync(Guid id, UpdateDocumentRequestDto updateDocumentRequestDto)
        {
            var now = DateTime.UtcNow;
            updateDocumentRequestDto.UpdatedAt = now;
            var oldDocumentRequest = await GetDocumentRequestByIdAsync(id);
            if (oldDocumentRequest != null)
            {
                if (oldDocumentRequest.Status != updateDocumentRequestDto.Status)
                    updateDocumentRequestDto.ProcessedAt = now;
            }
            var updatedDocumentRequest = await _documentRequestRepository.UpdateDocumentRequestAsync(id, updateDocumentRequestDto);

            return _mapper.Map<DocumentRequestDto>(updatedDocumentRequest);
        }

        public async Task DeleteDocumentRequestAsync(Guid id)
        {
            await _documentRequestRepository.DeleteDocumentRequestAsync(id);
        }

        public async Task<PagedResult<DocumentRequestDto>> GetDocumentRequestsByUserAsync(Guid userId, int pageNumber, int pageSize,
            string filter, bool usePagination)
        {
            var documentRequests = await _documentRequestRepository.GetDocumentRequestsByUserAsync(userId, pageNumber, pageSize,
                filter, usePagination);

            var pagedDocumentRequestsDto = new PagedResult<DocumentRequestDto>
            {
                Items = _mapper.Map<IEnumerable<DocumentRequestDto>>(documentRequests.Items),
                TotalItems = documentRequests.TotalItems,
                PageNumber = documentRequests.PageNumber,
                PageSize = documentRequests.PageSize
            };

            return pagedDocumentRequestsDto;
        }
    }
}
