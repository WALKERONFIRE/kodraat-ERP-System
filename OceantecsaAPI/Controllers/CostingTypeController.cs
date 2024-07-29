using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Infrastructure.IdentityServices;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostingTypeController : ControllerBase
    {
        private readonly ICostingTypeService _costingTypeService;

        public CostingTypeController(ICostingTypeService costingTypeService)
        {
            _costingTypeService = costingTypeService;
        }

        [HttpGet("AllCostingTypes")]
        public ActionResult GetAllCostingTypes()
        {
            var types = _costingTypeService.GetAllCostingTypes();
            return Ok(types);
        }

        [HttpGet("CostingType")]
        public ActionResult GetCostingType(int id)
        {
            var type = _costingTypeService.GetCostingType(id);
            if (type != null)
            {
                return Ok(type);
            }
            return BadRequest();
        }

        [HttpPost("AddCostingType")]
        public ActionResult AddCostingType(CostingTypeDTO cost)
        {
            _costingTypeService.AddCostingType(cost);
            return Ok();
        }

        [HttpDelete("DeleteCostingType")]
        public ActionResult DeleteCostingType(int id)
        {
            _costingTypeService.DeleteCostingType(id);
            return Ok();
        }

        [HttpPut("UpdateCostingType")]
        public ActionResult UpdateCostingType(int id, CostingTypeDTO costing)
        {
            _costingTypeService.UpdateCostingType(id, costing);
            return Ok();
        }
    }
}
