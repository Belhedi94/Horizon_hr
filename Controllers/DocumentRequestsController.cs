using Horizon_HR.Dtos.ApiResponse;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.DocumentRequest;
using Horizon_HR.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [Route("api/requests/documents")]
    [ApiController]
    public class DocuementRequestsController : ControllerBase
    {
        private readonly IDocumentRequestService _documentRequestService;

        public DocuementRequestsController(IDocumentRequestService documentRequestService)
        {
            _documentRequestService = documentRequestService;
        }

        /// <summary>
        /// Retrieves all document requests.
        /// </summary>
        /// <returns>A list of all document requests.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllDocumentRequestsAsync(int pageNumber = 1, int pageSize = 10, string filter = null,
            bool usePagintion = true)
        {
            var documentRequests = await _documentRequestService.GetAllDocumentRequestsAsync(pageNumber, pageSize, filter, usePagintion);
            if (!documentRequests.Items.Any())
                return Ok(new ApiResponse<PagedResult<DocumentRequestDto>>
                {
                    Status = 404,
                    Message = "No document requests found.",
                    Data = new PagedResult<DocumentRequestDto>
                    {
                        Items = Enumerable.Empty<DocumentRequestDto>(),
                        TotalItems = 0,
                        PageNumber = pageNumber,
                        PageSize = pageSize
                    }
                });

            return Ok(new ApiResponse<PagedResult<DocumentRequestDto>>
            {
                Status = 200,
                Message = "Document requests retrieved successfully.",
                Data = documentRequests
            });

        }

        /// <summary>
        /// Creates a new document request.
        /// </summary>
        /// <param name="createDocumentRequestDto">The data transfer object containing document request information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateDocumentRequestAsync(CreateDocumentRequestDto createDocumentRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newDocumentRequest = await _documentRequestService.CreateDocumentRequestAsync(createDocumentRequestDto);

            return Ok(new ApiResponse<DocumentRequestDto>
            {
                Status = 201,
                Message = "Document request created successfully.",
                Data = newDocumentRequest
            });
        }

        /// <summary>
        /// Retrieves a document request by ID.
        /// </summary>
        /// <param name="id">The ID of the document request to retrieve.</param>
        /// <returns>The document request data.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocumentRequestByIdAsync(Guid id)
        {
            var documentRequest = await _documentRequestService.GetDocumentRequestByIdAsync(id);

            return Ok(new ApiResponse<DocumentRequestDto>
            {
                Status = 200,
                Message = "Document request retrieved successfully.",
                Data = documentRequest
            });
        }


        /// <summary>
        /// Updates an existing document request.
        /// </summary>
        /// <param name="id">The ID of the document request to update.</param>
        /// <param name="updateDocumentRequestDto">The data transfer object containing updated document request information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDocumentRequestAsync(Guid id, UpdateDocumentRequestDto updateDocumentRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updatedDocumentRequest = await _documentRequestService.UpdateDocumentRequestAsync(id, updateDocumentRequestDto);

            return Ok(new ApiResponse<DocumentRequestDto>
            {
                Status = 200,
                Message = "Document request updated successfully.",
                Data = updatedDocumentRequest
            });
        }


        /// <summary>
        /// Deletes a document request by ID.
        /// </summary>
        /// <param name="id">The ID of the document request to delete.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocumentRequestAsync(Guid id)
        {
            await _documentRequestService.DeleteDocumentRequestAsync(id);

            return Ok(new ApiResponse<DocumentRequestDto>
            {
                Status = 200,
                Message = "Document request deleted successfully.",
                Data = { }
            });
        }

        /// <summary>
        /// Retrieves all document requests of a specific user.
        /// </summary>
        /// <returns>A list of all document requests.</returns>
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetDocumentRequestsByUserAsync(Guid userId, int pageNumber = 1, int pageSize = 10, string filter = null,
            bool usePagintion = true)
        {
            var documentRequests = await _documentRequestService.GetDocumentRequestsByUserAsync(userId, pageNumber, pageSize, filter, usePagintion);
            if (!documentRequests.Items.Any())
                return Ok(new ApiResponse<PagedResult<DocumentRequestDto>>
                {
                    Status = 404,
                    Message = "No document requests found.",
                    Data = new PagedResult<DocumentRequestDto>
                    {
                        Items = Enumerable.Empty<DocumentRequestDto>(),
                        TotalItems = 0,
                        PageNumber = pageNumber,
                        PageSize = pageSize
                    }
                });

            return Ok(new ApiResponse<PagedResult<DocumentRequestDto>>
            {
                Status = 200,
                Message = "Document requests retrieved successfully.",
                Data = documentRequests
            });

        }
    }
}
