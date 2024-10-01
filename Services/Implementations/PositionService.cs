using AutoMapper;
using Horizon_HR.Dtos.Positions;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;
using Horizon_HR.Models;

namespace Horizon_HR.Services.Implementations
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PositionService> _logger;

        public PositionService(IPositionRepository positionRepository, IMapper mapper, ILogger<PositionService> logger)
        {
            _positionRepository = positionRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<PositionDto>> GetAllPositionsAsync()
        {
            var positions = await _positionRepository.GetAllPositionsAsync();

            return _mapper.Map<IEnumerable<PositionDto>>(positions);
        }

        public async Task<PositionDto> CreatePositionAsync(CreatePositionDto createPositionDto)
        {
            var position = _mapper.Map<Position>(createPositionDto);
            var newPosition = await _positionRepository.CreatePositionAsync(position);

            return _mapper.Map<PositionDto>(newPosition);
        }

        public async Task<PositionDto> GetPositionByIdAsync(Guid id)
        {
            var position = await _positionRepository.GetPositionByIdAsync(id);

            return _mapper.Map<PositionDto>(position);
        }

        public async Task<PositionDto> UpdatePositionAsync(Guid id, UpdatePositionDto updatePositionDto)
        {
            var updatedPosition = await _positionRepository.UpdatePositionAsync(id, updatePositionDto);

            return _mapper.Map<PositionDto>(updatedPosition);
        }

        public async Task DeletePositionAsync(Guid id)
        {
            await _positionRepository.DeletePositionAsync(id);
        }
    }
}
