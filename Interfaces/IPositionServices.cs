using Horizon_HR.Contracts.Positions;

namespace Horizon_HR.Interfaces
{
    public interface IPositionServices
    {
        Task<IEnumerable<PositionDto>> GetAllPositionsAsync();
        Task CreatePositionAsync(CreatePositionDto createPositionDto);
        Task<PositionDto> GetPositionByIdAsync(Guid id);
        Task UpdatePositionAsync(Guid id, UpdatePositionDto updatePositionDto);
        Task DeletePositionAsync(Guid id);
    }
}
