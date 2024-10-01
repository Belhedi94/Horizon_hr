using Horizon_HR.Dtos.Positions;

namespace Horizon_HR.Services.Interfaces
{
    public interface IPositionService
    {
        Task<IEnumerable<PositionDto>> GetAllPositionsAsync();
        Task<PositionDto> CreatePositionAsync(CreatePositionDto createPositionDto);
        Task<PositionDto> GetPositionByIdAsync(Guid id);
        Task<PositionDto> UpdatePositionAsync(Guid id, UpdatePositionDto updatePositionDto);
        Task DeletePositionAsync(Guid id);
    }
}
