using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Contracts.Positions;
using Horizon_HR.Interfaces;
using Horizon_HR.Models;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Services
{
    public class PositionServices : IPositionServices
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<PositionServices> _logger;

        public PositionServices(DataBaseContext context, IMapper mapper, ILogger<PositionServices> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<PositionDto>> GetAllPositionsAsync()
        {
            var positions = await _context.Positions.ToListAsync();
            return _mapper.Map<IEnumerable<PositionDto>>(positions);
        }

        public async Task CreatePositionAsync(CreatePositionDto createPositionDto)
        {
            var position = _mapper.Map<Position>(createPositionDto);
            _context.Add(position);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePositionAsync(Guid id, UpdatePositionDto updatePositionDto)
        {
            var position = await _context.Positions.FindAsync(id);
            if (position == null)
                throw new Exception("Position not found");

            _mapper.Map(updatePositionDto, position);

            await _context.SaveChangesAsync();
        }

        public async Task<PositionDto> GetPositionByIdAsync(Guid id)
        {
            var position = await _context.Positions.FindAsync(id);
            if (position == null)
            {
                _logger.LogWarning($"Position with ID {id} not found.");
                throw new Exception("Position not found");
            }

            return _mapper.Map<PositionDto>(position);
        }

        public async Task DeletePositionAsync(Guid id)
        {
            var position = await _context.Positions.FindAsync(id);
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
