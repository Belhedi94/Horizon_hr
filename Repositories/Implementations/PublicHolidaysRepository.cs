using Horizon_HR.AppDataContext;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Repositories.Implementations
{
    public class PublicHolidaysRepository : IPublicHolidaysRepository
    {
        private readonly DataBaseContext _context;

        public PublicHolidaysRepository (DataBaseContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<DateTime>> GetPublicHolidaysBetweenGivenDaysAsync(DateTime startDate, DateTime? endDate)
        {
            IEnumerable<DateTime> publicHolidays;
            if (endDate == null)
                publicHolidays = await _context.PublicHolidays
                    .Where(p => p.StartDate == startDate)
                    .Select(p => p.StartDate)
                    .ToListAsync();

            else
                publicHolidays = await _context.PublicHolidays
                    .Where(p => p.StartDate >= startDate)
                    .Where(p => p.StartDate <= endDate)
                    .Select(p => p.StartDate)
                    .ToListAsync();

            return publicHolidays;
        }
    }
}
