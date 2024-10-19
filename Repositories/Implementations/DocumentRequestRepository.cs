using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Dtos.DocumentRequest;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Repositories.Implementations
{
    public class DocumentRequestRepository : IDocumentRequestRepository
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<DocumentRequestRepository> _logger;

        public DocumentRequestRepository(DataBaseContext context, IMapper mapper, ILogger<DocumentRequestRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PagedResult<DocumentRequest>> GetAllDocumentRequestsAsync(int pageNumber, int pageSize,
            string filter, bool usePagination = true)
        {
            var query = _context.DocumentRequests.AsQueryable();

            if (!string.IsNullOrEmpty(filter))
                query = query.Where(p => p.Type.Contains(filter) ||
                p.Description.Contains(filter) ||
                p.Status.Contains(filter)
                );

            var totalCount = await query.CountAsync();

            if (usePagination)
            {
                query = query
                .Skip((pageNumber - 1) * pageSize)
                .Include(d => d.User)
                .Take(pageSize);
            }

            var documentRequests = await query.ToListAsync();

            return new PagedResult<DocumentRequest>
            {
                Items = documentRequests,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public async Task<DocumentRequest> CreateDocumentRequestAsync(DocumentRequest documentRequest)
        {
            await _context.DocumentRequests.AddAsync(documentRequest);
            await _context.SaveChangesAsync();

            return documentRequest;
        }

        public async Task<DocumentRequest> GetDocumentRequestByIdAsync(Guid id)
        {
            var documentRequest = await _context.DocumentRequests
                .Include(d => d.User)
                .FirstOrDefaultAsync(d => d.Id == id);
            if (documentRequest == null)
            {
                _logger.LogWarning($"Document request with ID {id} not found.");
                throw new Exception("Document request not found");
            }

            return documentRequest;
        }

        public async Task<DocumentRequest> UpdateDocumentRequestAsync(Guid id, UpdateDocumentRequestDto updateDocumentRequestDto)
        {
            var documentRequest = await _context.DocumentRequests.FindAsync(id);
            if (documentRequest == null)
                throw new Exception("Document request not found");

            _mapper.Map(updateDocumentRequestDto, documentRequest);

            await _context.SaveChangesAsync();

            return documentRequest;
        }

        public async Task DeleteDocumentRequestAsync(Guid id)
        {
            var documentRequest = await GetDocumentRequestByIdAsync(id);
            if (documentRequest == null)
            {
                _logger.LogWarning($"Document Request with ID {id} not found.");
                throw new Exception("Document Request not found");
            }

            _context.DocumentRequests.Remove(documentRequest);

            await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<DocumentRequest>> GetDocumentRequestsByUserAsync(Guid userId, int pageNumber, int pageSize,
            string filter, bool usePagination)
        {
            var query = _context.DocumentRequests.AsQueryable();

            var totalCount = await query.CountAsync();

            if (usePagination)
            {
                query = query
                .Skip((pageNumber - 1) * pageSize)
                .Where(d => d.UserId == userId)
                .Include(d => d.User)
                .Take(pageSize);
            }

            var documentRequests = await query.ToListAsync();

            return new PagedResult<DocumentRequest>
            {
                Items = documentRequests,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}
