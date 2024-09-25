using Horizon_HR.Models;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface IPublicHolidaysRepository
    {
        Task<IEnumerable<DateTime>> GetPublicHolidaysBetweenGivenDaysAsync(DateTime startDate, DateTime? endDate);
    }
}
