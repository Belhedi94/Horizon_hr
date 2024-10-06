using Horizon_HR.Dtos.ApiResponse;
using Horizon_HR.Dtos.PagedResult;
using Horizon_HR.Dtos.Departments;
using Horizon_HR.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [Route("api/departments/")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentsController(IDepartmentService departmentServices)
        {
            _departmentService = departmentServices;
        }

        /// <summary>
        /// Retrieves all departments.
        /// </summary>
        /// <returns>A list of all departments.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllDepartmentsAsync(int pageNumber = 1, int pageSize = 10, string filter = null, bool usePagination = true)
        {
            var departments = await _departmentService.GetAllDepartmentsAsync(pageNumber, pageSize, filter, usePagination);
            if (!departments.Items.Any())
                return Ok(new ApiResponse<PagedResult<DepartmentDto>>
                {
                    Status = 404,
                    Message = "No departments found.",
                    Data = new PagedResult<DepartmentDto>
                    {
                        Items = Enumerable.Empty<DepartmentDto>(),
                        TotalItems = 0,
                        PageNumber = pageNumber,
                        PageSize = pageSize
                    }
                });

            return Ok(new ApiResponse<PagedResult<DepartmentDto>>
            {
                Status = 200,
                Message = "Departments retrieved successfully.",
                Data = departments
            });

        }

        /// <summary>
        /// Creates a new department.
        /// </summary>
        /// <param name="createDepartmentDto">The data transfer object containing department information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateDepartmentAsync(CreateDepartmentDto createDepartmentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newDepartment = await _departmentService.CreateDepartmentAsync(createDepartmentDto);

            return Ok(new ApiResponse<DepartmentDto>
            {
                Status = 201,
                Message = "Department created successfully.",
                Data = newDepartment
            });
        }

        /// <summary>
        /// Retrieves a department by ID.
        /// </summary>
        /// <param name="id">The ID of the department to retrieve.</param>
        /// <returns>The department data.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartmentByIdAsync(Guid id)
        {
            var department = await _departmentService.GetDepartmentByIdAsync(id);

            return Ok(new ApiResponse<DepartmentDto>
            {
                Status = 200,
                Message = "Department retrieved successfully.",
                Data = department
            });
        }


        /// <summary>
        /// Updates an existing department.
        /// </summary>
        /// <param name="id">The ID of the department to update.</param>
        /// <param name="updateDepartmentDto">The data transfer object containing updated department information.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDepartmentAsync(Guid id, UpdateDepartmentDto updateDepartmentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updatedDepartment = await _departmentService.UpdateDepartmentAsync(id, updateDepartmentDto);

            return Ok(new ApiResponse<DepartmentDto>
            {
                Status = 200,
                Message = "Department updated successfully.",
                Data = updatedDepartment
            });
        }


        /// <summary>
        /// Deletes a department by ID.
        /// </summary>
        /// <param name="id">The ID of the department to delete.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartmentAsync(Guid id)
        {
            await _departmentService.DeleteDepartmentAsync(id);

            return Ok(new ApiResponse<DepartmentDto>
            {
                Status = 200,
                Message = "Department deleted successfully.",
                Data = { }
            });
        }
    }
}
