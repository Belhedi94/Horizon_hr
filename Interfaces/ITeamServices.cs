using Horizon_HR.Contracts.Teams;

namespace Horizon_HR.Interfaces
{
    public interface ITeamServices
    {
        Task<IEnumerable<TeamDto>> GetAllTeamsAsync();
        Task CreateTeamAsync(CreateTeamDto createTeamDto);
        Task<TeamDto> GetTeamByIdAsync(Guid id);
        Task UpdateTeamAsync(Guid id, UpdateTeamDto updateTeamDto);
        Task DeleteTeamAsync(Guid id);
    }
}
