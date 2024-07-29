using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Domain.Models;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly ISectionServices _sectionServices;

        public SectionController(ISectionServices sectionServices)
        {
            _sectionServices = sectionServices;
        }

        [HttpGet("GetAllSections")]
        public IActionResult GetAllSections()
        {
            var sections = _sectionServices.GetAllSections();
            return Ok(sections);
        }

        [HttpGet("GetSection")]
        public IActionResult GetSection(int id)
        {
            var section = _sectionServices.GetSection(id);
            if (section == null)
                return NotFound();

            return Ok(section);
        }

        [HttpPost("AddSection")]
        public IActionResult AddSection(SectionDTO section)
        {
            _sectionServices.AddSection(section);
            return Ok();
        }

        [HttpPut("UpdateSection")]
        public IActionResult UpdateSection(int id, SectionDTO section)
        {
            var updated = _sectionServices.UpdateSection(id, section);
            if (!updated)
                return NotFound();

            return Ok();
        }

        [HttpDelete("RemoveSection")]
        public IActionResult RemoveSection(int id)
        {
            var removed = _sectionServices.RemoveSection(id);
            if (!removed)
                return NotFound();

            return Ok();
        }
    }
}
