using AutoMapper;
using Horizon_HR.AppDataContext;
using Horizon_HR.Contracts.Departments;
using Horizon_HR.Interfaces;
using Horizon_HR.Models;
using Microsoft.EntityFrameworkCore;

namespace Horizon_HR.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<DepartmentServices> _logger;

        public DepartmentServices(DataBaseContext context, IMapper mapper, ILogger<DepartmentServices> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync()
        {
            var departments = await _context.Departments.ToListAsync();
            return _mapper.Map<IEnumerable<DepartmentDto>>(departments);
        }

        public async Task CreateDepartmentAsync(CreateDepartmentDto createDepartmentDto)
        {
            var department = _mapper.Map<Department>(createDepartmentDto);
            _context.Add(department);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDepartmentAsync(Guid id, UpdateDepartmentDto updateDepartmentDto)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
                throw new Exception("Department not found");

            _mapper.Map(updateDepartmentDto, department);

            await _context.SaveChangesAsync();
        }

        public async Task<DepartmentDto> GetDepartmentByIdAsync(Guid id)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
            {
                _logger.LogWarning($"Department with ID {id} not found.");
                throw new Exception("Department not found");
            }

            return _mapper.Map<DepartmentDto>(department);
        }

        public async Task DeleteDepartmentAsync(Guid id)
        {
            var department = await _context.Departments.FindAsync(id);
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
