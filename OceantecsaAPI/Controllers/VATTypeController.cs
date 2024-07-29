using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VATTypeController : ControllerBase
    {
        private readonly IVATTypeService _vATTypeService;
        public VATTypeController(IVATTypeService vATTypeService)
        {
            _vATTypeService = vATTypeService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var vATTypeServices = await _vATTypeService.GetAll();
            return Ok(vATTypeServices);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var vATTypeService = await _vATTypeService.GetById(id);
            if (vATTypeService == null)
                return BadRequest("Not Found");
            return Ok(vATTypeService);
        }
        [HttpPost]
        public async Task<IActionResult> Create(VATTypesDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var vattype = new Vattype()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                Active = dto.Active,
                Vatpercentage = dto.Vatpercentage,
                IsDeleted = false
            };
            await _vATTypeService.Add(vattype);

            return Ok(vattype);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(VATTypesDto dto, int id)
        {
            var vattype = await _vATTypeService.GetById(id);
            if (vattype == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                vattype.EnglishName = dto.EnglishName;
                vattype.ArabicName = dto.ArabicName;
                vattype.Description = dto.Description;
                vattype.Active = dto.Active;
                vattype.Vatpercentage = dto.Vatpercentage;
                _vATTypeService.Update(vattype);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_vATTypeService.VattypeExists(vattype.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(vattype);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var vattype = await _vATTypeService.GetById(id);
            if (vattype == null)
                return BadRequest("Not Found");
            _vATTypeService.Delete(vattype);
            return Ok(vattype);
        }
    }
}
