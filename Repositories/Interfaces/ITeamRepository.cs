using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Teams;
using Horizon_HR.Models;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        Task<PagedResult<Team>> GetAllTeamsAsync(int pageNumber, int pageSize, string filter);
        Task CreateTeamAsync(CreateTeamDto createTeamDto);
        Task<TeamDto> GetTeamByIdAsync(Guid id);
        Task UpdateTeamAsync(Guid id, UpdateTeamDto updateTeamDto);
        Task DeleteTeamAsync(Guid id);
    }
}
