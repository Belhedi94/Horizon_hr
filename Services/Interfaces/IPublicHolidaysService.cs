using Horizon_HR.Models;

namespace Horizon_HR.Services.Interfaces
{
    public interface IPublicHolidaysService
    {
        Task<IEnumerable<DateTime>> GetPublicHolidaysBetweenGivenDaysAsync(DateTime startDate, DateTime? endDate);
    }
}
