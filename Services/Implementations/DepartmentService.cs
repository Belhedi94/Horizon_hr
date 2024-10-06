using AutoMapper;
using Horizon_HR.Dtos.Departments;
using Horizon_HR.Repositories.Interfaces;
using Horizon_HR.Services.Interfaces;
using Horizon_HR.Models;
using Horizon_HR.Dtos.PagedResult;

namespace Horizon_HR.Services.Implementations
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<DepartmentService> _logger;

        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper, ILogger<DepartmentService> logger)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PagedResult<DepartmentDto>> GetAllDepartmentsAsync(int pageNumber, int pageSize, string filter, bool usePagination)
        {
            var pagedDepartments = await _departmentRepository.GetAllDepartmentsAsync(pageNumber, pageSize, filter, usePagination);
            var pagedDepartmentsDto = new PagedResult<DepartmentDto>
            {
                Items = _mapper.Map<IEnumerable<DepartmentDto>>(pagedDepartments.Items),
                TotalItems = pagedDepartments.TotalItems,
                PageNumber = pagedDepartments.PageNumber,
                PageSize = pagedDepartments.PageSize
            };

            return pagedDepartmentsDto;

        }

        public async Task<DepartmentDto> CreateDepartmentAsync(CreateDepartmentDto createDepartmentDto)
        {
            var department = _mapper.Map<Department>(createDepartmentDto);
            var newDepartment = await _departmentRepository.CreateDepartmentAsync(department);

            return _mapper.Map<DepartmentDto>(newDepartment);
        }

        public async Task<DepartmentDto> GetDepartmentByIdAsync(Guid id)
        {
            var department = await _departmentRepository.GetDepartmentByIdAsync(id);

            return _mapper.Map<DepartmentDto>(department);
        }

        public async Task<DepartmentDto> UpdateDepartmentAsync(Guid id, UpdateDepartmentDto updateDepartmentDto)
        {
            var updatedDepartment = await _departmentRepository.UpdateDepartmentAsync(id, updateDepartmentDto);

            return _mapper.Map<DepartmentDto>(updatedDepartment);
        }

        public async Task DeleteDepartmentAsync(Guid id)
        {
            await _departmentRepository.DeleteDepartmentAsync(id);
        }
    }
}
