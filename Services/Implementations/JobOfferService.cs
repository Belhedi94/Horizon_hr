using AutoMapper;
using Horizon_HR.Dtos.JobOffer;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;

namespace Horizon_HR.Services.Implementations
{
    public class JobOfferService : IJobOfferService
    {
        private readonly IJobOfferRepository _jobOfferRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<JobOfferService> _logger;

        public JobOfferService(IJobOfferRepository jobOfferRepository, IMapper mapper, ILogger<JobOfferService> logger)
        {
            _jobOfferRepository = jobOfferRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PagedResult<JobOfferDto>> GetAllJobOffersAsync(int pageNumber, int pageSize, string filter, bool usePagination)
        {
            var pagedJobOffers = await _jobOfferRepository.GetAllJobOffersAsync(pageNumber, pageSize, filter, usePagination);
            var pagedJobOffersDto = new PagedResult<JobOfferDto>
            {
                Items = _mapper.Map<IEnumerable<JobOfferDto>>(pagedJobOffers.Items),
                TotalItems = pagedJobOffers.TotalItems,
                PageNumber = pagedJobOffers.PageNumber,
                PageSize = pagedJobOffers.PageSize
            };

            return pagedJobOffersDto;
        }

        public async Task<JobOfferDto> CreateJobOfferAsync(CreateJobOfferDto createJobOfferDto)
        {
            var jobOffer = _mapper.Map<JobOffer>(createJobOfferDto);
            var newJobOffer = await _jobOfferRepository.CreateJobOfferAsync(jobOffer);

            return _mapper.Map<JobOfferDto>(newJobOffer);
        }

        public async Task<JobOfferDto> GetJobOfferByIdAsync(Guid id)
        {
            var jobOffer = await _jobOfferRepository.GetJobOfferByIdAsync(id);

            return _mapper.Map<JobOfferDto>(jobOffer);
        }

        public async Task<JobOfferDto> UpdateJobOfferAsync(Guid id, UpdateJobOfferDto updateJobOfferDto)
        {
            updateJobOfferDto.UpdatedAt = DateTime.UtcNow;
            var updatedJobOffer = await _jobOfferRepository.UpdateJobOfferAsync(id, updateJobOfferDto);
           
            return _mapper.Map<JobOfferDto>(updatedJobOffer);
        }

        public async Task DeleteJobOfferAsync(Guid id)
        {
            await _jobOfferRepository.DeleteJobOfferAsync(id);
        }
    }
}
