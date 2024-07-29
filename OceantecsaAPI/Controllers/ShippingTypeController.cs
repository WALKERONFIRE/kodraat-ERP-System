using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingTypeController:ControllerBase
    {
        private readonly IShippingTypeService _shippingTypeService;

        public ShippingTypeController(IShippingTypeService  shippingType)
        {
            _shippingTypeService = shippingType;
        }

        // GET api/SupplierGroup/AllSupplierGroup
        [HttpGet("AllShippingType")]
        public ActionResult<IEnumerable<ShippingType>> AllSupplierGroup()
        {
            var allSupplierGroups = _shippingTypeService.GetAllShippingType();
            return Ok(allSupplierGroups);
        }

        // GET api/SupplierGroup/SupplierGroup/{id}
        [HttpGet("ShippingType/{id}")]
        public ActionResult<SupplierActivity> GetSupplierActivity(int id)
        {
            var supplierGroup = _shippingTypeService.GetShippingType(id);
            if (supplierGroup == null)
            {
                return NotFound(); // Return a 404 response if the entity is not found
            }
            return Ok(supplierGroup);
        }

        // POST api/SupplierGroup/AddSupplierGroup
        [HttpPost("AddShippingType")]
        public ActionResult AddSupplierGroup(ShippingTypeDTO  shippingType)
        {
            _shippingTypeService.AddShippingType(shippingType);
            return Ok();
        }

        // PUT api/SupplierGroup/EditSupplierGroup/{id}
        [HttpPut("EditShippingType/{id}")]
        public ActionResult EditShippingType(int id, ShippingTypeDTO shippingType)
        {
            _shippingTypeService.EditShippingType(id, shippingType);
            return Ok();
        }

        // DELETE api/SupplierGroup/DeleteSupplierGroup/{id}
        [HttpDelete("DeleteShippingType/{id}")]
        public ActionResult DeleteShippingType(int id)
        {
            _shippingTypeService.DeleteShippingType(id);
            return Ok();
        }
    }
}

