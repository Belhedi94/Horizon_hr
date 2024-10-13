using AutoMapper;
using Horizon_HR.Dtos.Teams;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;
using Horizon_HR.Dtos.PagedResult;

namespace Horizon_HR.Services.Implementations
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<TeamService> _logger;

        public TeamService(ITeamRepository teamRepository, IMapper mapper, ILogger<TeamService> logger)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PagedResult<TeamDto>> GetAllTeamsAsync(int pageNumber, int pageSize, string filter, bool usePagination)
        {
            var pagedTeams = await _teamRepository.GetAllTeamsAsync(pageNumber, pageSize, filter, usePagination);
            var pagedTeamsDto = new PagedResult<TeamDto>
            {
                Items = _mapper.Map<IEnumerable<TeamDto>>(pagedTeams.Items),
                TotalItems = pagedTeams.TotalItems,
                PageNumber = pagedTeams.PageNumber,
                PageSize = pagedTeams.PageSize
            };

            return pagedTeamsDto;

        }

    }
}
