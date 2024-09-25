using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;

namespace Horizon_HR.Services.Implementations
{
    public class PublicHolidaysService : IPublicHolidaysService
    {
        private readonly IPublicHolidaysRepository _publicHolidaysRepository;

        public PublicHolidaysService(IPublicHolidaysRepository publicHolidaysRepository)
        {
            _publicHolidaysRepository = publicHolidaysRepository;
        }

        public async Task<IEnumerable<DateTime>> GetPublicHolidaysBetweenGivenDaysAsync(DateTime startDate, DateTime? endDate)
        {
            var publicHolidays = await _publicHolidaysRepository.GetPublicHolidaysBetweenGivenDaysAsync(startDate, endDate);

            return publicHolidays;
        }
    }
}
