using Horizon_HR.Dtos.Teams;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        Task<IEnumerable<TeamDto>> GetAllTeamsAsync();
        Task CreateTeamAsync(CreateTeamDto createTeamDto);
        Task<TeamDto> GetTeamByIdAsync(Guid id);
        Task UpdateTeamAsync(Guid id, UpdateTeamDto updateTeamDto);
        Task DeleteTeamAsync(Guid id);
    }
}
