﻿using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Contracts.Teams;
using Horizon_HR.Interfaces;
using Horizon_HR.Models;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Services
{
    public class TeamServices : ITeamServices
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<TeamServices> _logger;

        public TeamServices(DataBaseContext context, IMapper mapper, ILogger<TeamServices> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<TeamDto>> GetAllTeamsAsync()
        {
            var teams = await _context.Teams.ToListAsync();
            return _mapper.Map<IEnumerable<TeamDto>>(teams);
        }

        public async Task CreateTeamAsync(CreateTeamDto createTeamDto)
        {
            var team = _mapper.Map<Team>(createTeamDto);
            _context.Add(team);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTeamAsync(Guid id, UpdateTeamDto updateTeamDto)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
                throw new Exception("Team not found");

            _mapper.Map(updateTeamDto, team);

            await _context.SaveChangesAsync();
        }

        public async Task<TeamDto> GetTeamByIdAsync(Guid id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                _logger.LogWarning($"Team with ID {id} not found.");
                throw new Exception("Team not found");
            }

            return _mapper.Map<TeamDto>(team);
        }

        public async Task DeleteTeamAsync(Guid id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                _logger.LogWarning($"Team with ID {id} not found.");
                throw new Exception("Team not found");
            }

            _context.Teams.Remove(team);

            await _context.SaveChangesAsync();
        }
    }
}
