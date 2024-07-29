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
    public class ProductionTypeController : ControllerBase
    {
        private readonly IProductionTypeService _productionTypeService;
        public ProductionTypeController(IProductionTypeService productionTypeService)
        {
            _productionTypeService = productionTypeService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var productionTypes = await _productionTypeService.GetAll();
            return Ok(productionTypes);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var productionType = await _productionTypeService.GetById(id);
            if (productionType == null)
                return BadRequest("Not Found");
            return Ok(productionType);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductProductionDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var productionType = new ProductProductionType()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                Active = dto.Active,
                IsDeleted = false
            };
            await _productionTypeService.Add(productionType);

            return Ok(productionType);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(ProductProductionDto dto, int id)
        {
            var productionType = await _productionTypeService.GetById(id);
            if (productionType == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                productionType.EnglishName = dto.EnglishName;
                productionType.ArabicName = dto.ArabicName;
                productionType.Description = dto.Description;
                productionType.Active = dto.Active;
                _productionTypeService.Update(productionType);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_productionTypeService.ProductProductionTypeExists(productionType.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(productionType);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var productionType = await _productionTypeService.GetById(id);
            if (productionType == null)
                return BadRequest("Not Found");
            _productionTypeService.Delete(productionType);
            return Ok(productionType);
        }
    }
}
