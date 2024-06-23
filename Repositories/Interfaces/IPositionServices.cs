using Horizon_HR.Dtos.Positions;

namespace Horizon_HR.Repositories.Interfaces
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
