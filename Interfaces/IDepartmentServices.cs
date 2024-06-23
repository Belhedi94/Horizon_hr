﻿using Horizon_HR.Contracts.Departments;

namespace Horizon_HR.Interfaces
{
    public interface IDepartmentServices
    {
        Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync();
        Task CreateDepartmentAsync(CreateDepartmentDto createDepartmentDto);
        Task<DepartmentDto> GetDepartmentByIdAsync(Guid id);
        Task UpdateDepartmentAsync(Guid id, UpdateDepartmentDto updateDepartmentDto);
        Task DeleteDepartmentAsync(Guid id);
    }
}
