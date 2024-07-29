using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SupplierActivityController:ControllerBase
    {
        private readonly ISupplierActivityServices _supplierActivityServices;

        public SupplierActivityController(ISupplierActivityServices  supplierActivityServices)
        {
            _supplierActivityServices = supplierActivityServices;
        }

        // GET api/SupplierGroup/AllSupplierGroup
        [HttpGet("AllSupplierActivity")]
        public ActionResult<IEnumerable<SupplierActivity>> AllSupplierActivity()
        {
            var allSupplierGroups = _supplierActivityServices.GetAllSupplierGroups();
            return Ok(allSupplierGroups);
        }

        // GET api/SupplierGroup/SupplierGroup/{id}
        [HttpGet("SupplierActivity/{id}")]
        public ActionResult<SupplierActivity> GetSupplierActivity(int id)
        {
            var supplierGroup = _supplierActivityServices.GetSupplierActivity(id);
            if (supplierGroup == null)
            {
                return NotFound(); // Return a 404 response if the entity is not found
            }
            return Ok(supplierGroup);
        }

        // POST api/SupplierGroup/AddSupplierGroup
        [HttpPost("AddSupplierActivity")]
        public ActionResult AddSupplierActivity(SupplierActivityDTO  supplierActivity)
        {
            _supplierActivityServices.AddSupplierActivity(supplierActivity);
            return Ok();
        }

        // PUT api/SupplierGroup/EditSupplierGroup/{id}
        [HttpPut("EditSupplierActivity")]
        public ActionResult EditSupplierActivity(int id, SupplierActivityDTO supplierActivity)
        {
            _supplierActivityServices.EditSupplierActivity(id, supplierActivity);
            return Ok();
        }

        // DELETE api/SupplierGroup/DeleteSupplierGroup/{id}
        [HttpDelete("DeleteSupplierActivity")]
        public ActionResult DeleteSupplierActivity(int id)
        {
            _supplierActivityServices.DeleteSupplierActivity(id);
            return Ok();
        }
    }
}

