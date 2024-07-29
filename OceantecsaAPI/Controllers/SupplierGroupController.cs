using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.IdentityServices; // Import the service namespace
using Oceantecsa.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierGroupController : ControllerBase
    {
        private readonly ISupplierGroupServices _supplierGroupService;

        public SupplierGroupController(ISupplierGroupServices supplierGroupService)
        {
            _supplierGroupService = supplierGroupService;
        }

        // GET api/SupplierGroup/AllSupplierGroup
        [HttpGet("AllSupplierGroup")]
        public ActionResult<IEnumerable<SupplierGroup>> AllSupplierGroup()
        {
            var allSupplierGroups = _supplierGroupService.GetAllSupplierGroups();
            return Ok(allSupplierGroups);
        }

        // GET api/SupplierGroup/SupplierGroup/{id}
        [HttpGet("SupplierGroup/{id}")]
        public ActionResult<SupplierGroup> GetSupplierGroup(int id)
        {
            var supplierGroup = _supplierGroupService.GetSupplierGroup(id);
            if (supplierGroup == null)
            {
                return NotFound(); // Return a 404 response if the entity is not found
            }
            return Ok(supplierGroup);
        }

        // POST api/SupplierGroup/AddSupplierGroup
        [HttpPost("AddSupplierGroup")]
        public ActionResult AddSupplierGroup(SupplierGroupDTO supplierGroup)
        {
            _supplierGroupService.AddSupplierGroup(supplierGroup);
            return Ok();
        }

        // PUT api/SupplierGroup/EditSupplierGroup/{id}
        [HttpPut("EditSupplierGroup/{id}")]
        public ActionResult EditSupplierGroup(int id, SupplierGroupDTO supplierGroup)
        {
            _supplierGroupService.EditSupplierGroup(id, supplierGroup);
            return Ok();
        }

        // DELETE api/SupplierGroup/DeleteSupplierGroup/{id}
        [HttpDelete("DeleteSupplierGroup/{id}")]
        public ActionResult DeleteSupplierGroup(int id)
        {
            _supplierGroupService.DeleteSupplierGroup(id);
            return Ok();
        }
    }
}
