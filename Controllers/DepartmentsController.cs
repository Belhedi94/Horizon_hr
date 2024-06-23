using Horizon_HR.Dtos.Departments;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon_HR.Controllers
{
    [Route("api/departments/")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentServices _departmentServices;

        public DepartmentsController(IDepartmentServices departmentServices)
        {
            _departmentServices = departmentServices;
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
            {
                return BadRequest(ModelState);
            }

            await _departmentServices.CreateDepartmentAsync(createDepartmentDto);

            return Ok(new {message = "Department created successfully."});
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

            await _departmentServices.UpdateDepartmentAsync(id, updateDepartmentDto);

            return Ok(new { message = "Department updated successfully." });
        }

        /// <summary>
        /// Retrieves all departments.
        /// </summary>
        /// <returns>A list of all departments.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllDepartmentsAsync()
        {
            var departments = await _departmentServices.GetAllDepartmentsAsync();
            if (!departments.Any())
                return Ok(new { message = "No departments found", data = Enumerable.Empty<DepartmentDto>() });

            return Ok(new { message = "Departments retrieved successfully", data = departments });

        }

        /// <summary>
        /// Retrieves a department by ID.
        /// </summary>
        /// <param name="id">The ID of the department to retrieve.</param>
        /// <returns>The department data.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartmentByIdAsync(Guid id)
        {
            var department = await _departmentServices.GetDepartmentByIdAsync(id);
            return Ok(new { message = "Department retrieved successfully.", data = department });
        }

        /// <summary>
        /// Deletes a department by ID.
        /// </summary>
        /// <param name="id">The ID of the department to delete.</param>
        /// <returns>A status message indicating the result of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartmentAsync(Guid id)
        {
            await _departmentServices.DeleteDepartmentAsync(id);
            return Ok(new { message = "Department deleted successfully." });
        }
    }
}
