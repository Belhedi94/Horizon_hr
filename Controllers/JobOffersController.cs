using Horizon_HR.Dtos.ApiResponse;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.JobOffer;
using Horizon_HR.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [Route("api/jobs/offers")]
    [ApiController]
    public class JobOffersController : ControllerBase
    {
        private readonly IJobOfferService _jobOfferService;

        public JobOffersController(IJobOfferService jobOfferServices)
        {
            _jobOfferService = jobOfferServices;
        }

        /// <summary>
        /// Retrieves all job offers.
        /// </summary>
        /// <returns>A list of all job offers.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllJobOffersAsync(int pageNumber = 1, int pageSize = 10, string filter = null, bool usePagination = true)
        {
            var jobOffers = await _jobOfferService.GetAllJobOffersAsync(pageNumber, pageSize, filter, usePagination);
            if (!jobOffers.Items.Any())
                return Ok(new ApiResponse<PagedResult<JobOfferDto>>
                {
                    Status = 404,
                    Message = "No job offers found.",
                    Data = new PagedResult<JobOfferDto>
                    {
                        Items = Enumerable.Empty<JobOfferDto>(),
                        TotalItems = 0,
                        PageNumber = pageNumber,
                        PageSize = pageSize
                    }
                });

            return Ok(new ApiResponse<PagedResult<JobOfferDto>>
            {
                Status = 200,
                Message = "Job offers retrieved successfully.",
                Data = jobOffers
            });

        }

        /// <summary>
        /// Creates a new job offer.
        /// </summary>
        /// <param name="createJobOfferDto">The data transfer object containing job offer information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateJobOfferAsync(CreateJobOfferDto createJobOfferDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newJobOffer = await _jobOfferService.CreateJobOfferAsync(createJobOfferDto);

            return Ok(new ApiResponse<JobOfferDto>
            {
                Status = 201,
                Message = "Job offer created successfully.",
                Data = newJobOffer
            });
        }

        /// <summary>
        /// Retrieves a job offer by ID.
        /// </summary>
        /// <param name="id">The ID of the job offer to retrieve.</param>
        /// <returns>The job offer data.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJobOfferByIdAsync(Guid id)
        {
            var jobOffer = await _jobOfferService.GetJobOfferByIdAsync(id);

            return Ok(new ApiResponse<JobOfferDto>
            {
                Status = 200,
                Message = "Job offer retrieved successfully.",
                Data = jobOffer
            });
        }


        /// <summary>
        /// Updates an existing job offer.
        /// </summary>
        /// <param name="id">The ID of the job offer to update.</param>
        /// <param name="updateJobOfferDto">The data transfer object containing updated job offer information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJobOfferAsync(Guid id, UpdateJobOfferDto updateJobOfferDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updatedJobOffer = await _jobOfferService.UpdateJobOfferAsync(id, updateJobOfferDto);

            return Ok(new ApiResponse<JobOfferDto>
            {
                Status = 200,
                Message = "Job offer updated successfully.",
                Data = updatedJobOffer
            });
        }


        /// <summary>
        /// Deletes a job offer by ID.
        /// </summary>
        /// <param name="id">The ID of the job offer to delete.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobOfferAsync(Guid id)
        {
            await _jobOfferService.DeleteJobOfferAsync(id);

            return Ok(new ApiResponse<JobOfferDto>
            {
                Status = 200,
                Message = "Job offer deleted successfully.",
                Data = { }
            });
        }
    }
}
