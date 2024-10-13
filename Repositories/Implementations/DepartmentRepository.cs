using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Departments;
using Horizon_HR.Models;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Repositories.Implementations
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<DepartmentRepository> _logger;

        public DepartmentRepository(DataBaseContext context, IMapper mapper, ILogger<DepartmentRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PagedResult<Department>> GetAllDepartmentsAsync(int pageNumber, int pageSize, string filter, bool usePagination)
        {
            var query = _context.Departments.AsQueryable();

            if (!string.IsNullOrEmpty(filter))
                query = query.Where(p => p.Name.Contains(filter) || p.Description.Contains(filter));

            var totalCount = await query.CountAsync();

            if (usePagination)
            {
                query = query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
            }

            var departments = await query.ToListAsync();

            return new PagedResult<Department>
            {
                Items = departments,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public async Task<Department> CreateDepartmentAsync(Department department)
        {
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();

            return department;
        }

        public async Task<Department> GetDepartmentByIdAsync(Guid id)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
            {
                _logger.LogWarning($"Department with ID {id} not found.");
                throw new Exception("Department not found");
            }

            return department;
        }

        public async Task<Department> UpdateDepartmentAsync(Guid id, UpdateDepartmentDto updateDepartmentDto)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
                throw new Exception("Department not found");

            _mapper.Map(updateDepartmentDto, department);

            await _context.SaveChangesAsync();

            return department;
        }

        public async Task DeleteDepartmentAsync(Guid id)
        {
            var department = await GetDepartmentByIdAsync(id);
            if (department == null)
            {
                _logger.LogWarning($"Department with ID {id} not found.");
                throw new Exception("Department not found");
            }

            _context.Departments.Remove(department);

            await _context.SaveChangesAsync();
        }
    }
}
