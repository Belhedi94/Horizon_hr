using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Dtos.JobOffer;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Repositories.Implementations
{
    public class JobOfferRepository : IJobOfferRepository
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<JobOfferRepository> _logger;

        public JobOfferRepository(DataBaseContext context, IMapper mapper, ILogger<JobOfferRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PagedResult<JobOffer>> GetAllJobOffersAsync(int pageNumber, int pageSize, string filter, bool usePagination)
        {
            var query = _context.JobOffers.AsQueryable();

            if (!string.IsNullOrEmpty(filter))
                query = query.Where(p => p.Title.Contains(filter) ||
                p.Location.Contains(filter) ||
                p.Status.Contains(filter) ||
                p.EmploymentType.Contains(filter));

            var totalCount = await query.CountAsync();

            if (usePagination)
            {
                query = query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
            }

            var jobOffers = await query.ToListAsync();

            return new PagedResult<JobOffer>
            {
                Items = jobOffers,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public async Task<JobOffer> CreateJobOfferAsync(JobOffer offer)
        {
            await _context.JobOffers.AddAsync(offer);
            await _context.SaveChangesAsync();

            return offer;
        }

        public async Task<JobOffer> GetJobOfferByIdAsync(Guid id)
        {
            var jobOffer = await _context.JobOffers.FindAsync(id);
            if (jobOffer == null)
            {
                _logger.LogWarning($"Job offer with ID {id} not found.");
                throw new Exception("Job offer not found");
            }

            return jobOffer;
        }

        public async Task<JobOffer> UpdateJobOfferAsync(Guid id, UpdateJobOfferDto updateJobOfferDto)
        {
            var jobOffer = await _context.JobOffers.FindAsync(id);
            if (jobOffer == null)
                throw new Exception("Job offers not found");

            _mapper.Map(updateJobOfferDto, jobOffer);

            await _context.SaveChangesAsync();

            return jobOffer;
        }

        public async Task DeleteJobOfferAsync(Guid id)
        {
            var jobOffer = await GetJobOfferByIdAsync(id);
            if (jobOffer == null)
            {
                _logger.LogWarning($"Job offer with ID {id} not found.");
                throw new Exception("Job offer not found");
            }

            _context.JobOffers.Remove(jobOffer);

            await _context.SaveChangesAsync();
        }
    }
}
