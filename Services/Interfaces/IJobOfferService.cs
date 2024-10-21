using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.JobOffer;

namespace Horizon_HR.Services.Interfaces
{
    public interface IJobOfferService
    {
        Task<PagedResult<JobOfferDto>> GetAllJobOffersAsync(int pageNumber, int pageSize, string filter, bool usePagination);
        Task<JobOfferDto> CreateJobOfferAsync(CreateJobOfferDto createJobOfferDto);
        Task<JobOfferDto> GetJobOfferByIdAsync(Guid id);
        Task<JobOfferDto> UpdateJobOfferAsync(Guid id, UpdateJobOfferDto updateJobOfferDto);
        Task DeleteJobOfferAsync(Guid id);
    }
}
