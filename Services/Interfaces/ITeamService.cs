using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Teams;

namespace Horizon_HR.Services.Interfaces
{
    public interface ITeamService
    {
        Task<PagedResult<TeamDto>> GetAllTeamsAsync(int pageNumber, int pageSize, string filter);
    }
}
