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
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeService _productTypeService;
        public ProductTypeController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var productTypes = await _productTypeService.GetAll();
            return Ok(productTypes);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var productType = await _productTypeService.GetById(id);
            if (productType == null)
                return BadRequest("Not Found");
            return Ok(productType);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductTypeDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var productType = new ProductType()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                Active = dto.Active,
                IsDeleted = false
            };
            await _productTypeService.Add(productType);

            return Ok(productType);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(ProductTypeDto dto, int id)
        {
            var productType = await _productTypeService.GetById(id);
            if (productType == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                productType.EnglishName = dto.EnglishName;
                productType.ArabicName = dto.ArabicName;
                productType.Description = dto.Description;
                productType.Active = dto.Active;
                _productTypeService.Update(productType);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_productTypeService.ProductTypeExists(productType.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(productType);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var productType = await _productTypeService.GetById(id);
            if (productType == null)
                return BadRequest("Not Found");
            _productTypeService.Delete(productType);
            return Ok(productType);
        }
    }
}
