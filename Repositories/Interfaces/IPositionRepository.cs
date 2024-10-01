using Horizon_HR.Dtos.Positions;
using Horizon_HR.Models;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface IPositionRepository
    {
        Task<IEnumerable<Position>> GetAllPositionsAsync();
        Task<Position> CreatePositionAsync(Position position);
        Task<Position> GetPositionByIdAsync(Guid id);
        Task<Position> UpdatePositionAsync(Guid id, UpdatePositionDto updatePositionDto);
        Task DeletePositionAsync(Guid id);
    }
}
