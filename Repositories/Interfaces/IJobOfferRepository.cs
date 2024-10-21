using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.JobOffer;
using Horizon_HR.Models;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface IJobOfferRepository
    {
        Task<PagedResult<JobOffer>> GetAllJobOffersAsync(int pageNumber, int pageSize, string filter, bool usePagintion);
        Task<JobOffer> CreateJobOfferAsync(JobOffer offer);
        Task<JobOffer> GetJobOfferByIdAsync(Guid id);
        Task<JobOffer> UpdateJobOfferAsync(Guid id, UpdateJobOfferDto updateJobOfferDto);
        Task DeleteJobOfferAsync(Guid id);
    }
}
