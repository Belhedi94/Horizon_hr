using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Departments;

namespace Horizon_HR.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task<PagedResult<DepartmentDto>> GetAllDepartmentsAsync(int pageNumber, int pageSize, string filter, bool usePagination);
        Task<DepartmentDto> CreateDepartmentAsync(CreateDepartmentDto createDepartmentDto);
        Task<DepartmentDto> GetDepartmentByIdAsync(Guid id);
        Task<DepartmentDto> UpdateDepartmentAsync(Guid id, UpdateDepartmentDto updateDepartmentDto);
        Task DeleteDepartmentAsync(Guid id);
    }
}
