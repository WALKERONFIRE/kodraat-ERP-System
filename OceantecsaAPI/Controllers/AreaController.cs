using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Domain.Models;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaServices _areaServices;

        public AreaController(IAreaServices areaServices)
        {
            _areaServices = areaServices;
        }

        [HttpGet("GetAllAreas")]
        public IActionResult GetAllAreas()
        {
            var areas = _areaServices.GetAllAreas();
            return Ok(areas);
        }

        [HttpGet("GetArea")]
        public IActionResult GetArea(int id)
        {
            var area = _areaServices.GetArea(id);
            if (area == null)
                return NotFound();

            return Ok(area);
        }

        [HttpPost("AddArea")]
        public IActionResult AddArea(AreaDTO area)
        {
            _areaServices.AddArea(area);
            return Ok();
        }

        [HttpPut("UpdateArea")]
        public IActionResult UpdateArea(int id, AreaDTO area)
        {
            _areaServices.UpdateArea(id, area);
            return Ok();
        }

        [HttpDelete("RemoveArea")]
        public IActionResult RemoveArea(int id)
        {
            _areaServices.RemoveArea(id);
            return Ok();
        }
    }
}
