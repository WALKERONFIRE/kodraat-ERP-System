using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController:ControllerBase
    {
        private readonly ISupplierServices _SupplierService;

        public SupplierController(ISupplierServices supplier)
        {
            _SupplierService = supplier;
        }

        // GET api/SupplierGroup/AllSupplierGroup
        [HttpGet("AllGetSupplier")]
        public ActionResult<IEnumerable<Supplier>> AllSupplierGroup()
        {
            var allSupplier = _SupplierService.GetAllSupplier();
            return Ok(allSupplier);
        }

        // GET api/SupplierGroup/SupplierGroup/{id}
        [HttpGet("GetSupplier")]
        public ActionResult<Supplier> GetSupplier(int id)
        {
            var supplier = _SupplierService.GetSupplier(id);
            if (supplier == null)
            {
                return NotFound(); // Return a 404 response if the entity is not found
            }
            return Ok(supplier);
        }

        // POST api/SupplierGroup/AddSupplierGroup
        [HttpPost("AddSupplier")]
        public ActionResult AddSupplier(SupplierDTO  supplier)
        {
            _SupplierService.AddSupplier(supplier);
            return Ok();
        }

        // PUT api/SupplierGroup/EditSupplierGroup/{id}
        [HttpPut("EditSupplier")]
        public ActionResult EditSupplier(int id, SupplierDTO  supplier)
        {
            _SupplierService.EditSupplier(id,supplier);
            return Ok();
        }

        // DELETE api/SupplierGroup/DeleteSupplierGroup/{id}
        [HttpDelete("DeleteSupplier")]
        public ActionResult DeleteSupplier(int id)
        {
            _SupplierService.DeleteSupplier(id);
            return Ok();
        }
    }
}
