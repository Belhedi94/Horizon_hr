using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Dtos.Positions;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Repositories.Implementations
{
    public class PositionRepository : IPositionRepository
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<PositionRepository> _logger;

        public PositionRepository(DataBaseContext context, IMapper mapper, ILogger<PositionRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<Position>> GetAllPositionsAsync()
        {
            var positions = await _context.Positions.ToListAsync();
            return positions;
        }

        public async Task<Position> CreatePositionAsync(Position position)
        {
            await _context.Positions.AddAsync(position);
            await _context.SaveChangesAsync();

            return position;
        }

        public async Task<Position> GetPositionByIdAsync(Guid id)
        {
            var position = await _context.Positions.FindAsync(id);
            if (position == null)
            {
                _logger.LogWarning($"Position with ID {id} not found.");
                throw new Exception("Position not found");
            }

            return position;
        }

        public async Task<Position> UpdatePositionAsync(Guid id, UpdatePositionDto updatePositionDto)
        {
            var position = await _context.Positions.FindAsync(id);
            if (position == null)
                throw new Exception("Position not found");

            _mapper.Map(updatePositionDto, position);

            await _context.SaveChangesAsync();

            return position;
        }

        public async Task DeletePositionAsync(Guid id)
        {
            var position = await GetPositionByIdAsync(id);
            if (position == null)
            {
                _logger.LogWarning($"Position with ID {id} not found.");
                throw new Exception("Position not found");
            }

            _context.Positions.Remove(position);

            await _context.SaveChangesAsync();
        }
    }
}
