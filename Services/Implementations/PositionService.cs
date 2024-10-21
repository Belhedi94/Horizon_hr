using AutoMapper;
using Horizon_HR.Dtos.Positions;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;
using Horizon_HR.Models;
using Horizon_HR.Dtos.PagedResult;

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

        public async Task<PagedResult<PositionDto>> GetAllPositionsAsync(int pageNumber, int pageSize,
            string filter, bool usePagination)
        {
            var pagedPositions = await _positionRepository.GetAllPositionsAsync(pageNumber, pageSize, filter,
                usePagination);
            var pagedPositionsDto = new PagedResult<PositionDto>
            {
                Items = _mapper.Map<IEnumerable<PositionDto>>(pagedPositions.Items),
                TotalItems = pagedPositions.TotalItems,
                PageNumber = pagedPositions.PageNumber,
                PageSize = pagedPositions.PageSize
            };

            return pagedPositionsDto;

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
