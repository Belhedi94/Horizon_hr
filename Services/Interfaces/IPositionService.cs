using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Positions;

namespace Horizon_HR.Services.Interfaces
{
    public interface IPositionService
    {
        Task<PagedResult<PositionDto>> GetAllPositionsAsync(int pageNumber, int pageSize, string filter,
            bool usePagination);
        Task<PositionDto> CreatePositionAsync(CreatePositionDto createPositionDto);
        Task<PositionDto> GetPositionByIdAsync(Guid id);
        Task<PositionDto> UpdatePositionAsync(Guid id, UpdatePositionDto updatePositionDto);
        Task DeletePositionAsync(Guid id);
    }
}
