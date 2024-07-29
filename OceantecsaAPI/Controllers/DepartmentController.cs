using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Infrastructure.IdentityServices; // Include the namespace for the service

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("AllDepartments")]
        public ActionResult GetAllDepartments()
        {
            var departments = _departmentService.GetAllDepartments();
            return Ok(departments);
        }

        [HttpGet("Departments")]
        public ActionResult GetDepartment(int id)
        {
            var department = _departmentService.GetDepartment(id);
            if (department != null)
            {
                return Ok(department);
            }
            return BadRequest();
        }

        [HttpPost("AddDepartment")]
        public ActionResult AddDepartment(DepartmentDTO department)
        {
            _departmentService.AddDepartment(department);
            return Ok();
        }

        [HttpDelete("DeleteDepartment")]
        public ActionResult DeleteDepartment(int id)
        {
            _departmentService.DeleteDepartment(id);
            return Ok();
        }

        [HttpPut("UpdateDepartment")]
        public ActionResult UpdateDepartment(int id, DepartmentDTO department)
        {
            _departmentService.UpdateDepartment(id, department);
            return Ok();
        }
    }
}
