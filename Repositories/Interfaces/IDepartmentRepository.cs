using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Departments;
using Horizon_HR.Models;

namespace Horizon_HR.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<PagedResult<Department>> GetAllDepartmentsAsync(int pageNumber, int pageSize, string filter, bool usePagination);
        Task<Department> CreateDepartmentAsync(Department department);
        Task<Department> GetDepartmentByIdAsync(Guid id);
        Task<Department> UpdateDepartmentAsync(Guid id, UpdateDepartmentDto updateDepartmentDto);
        Task DeleteDepartmentAsync(Guid id);
    }
}
