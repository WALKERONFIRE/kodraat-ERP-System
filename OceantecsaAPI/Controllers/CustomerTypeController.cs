using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Domain.Models;
namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerTypeController : ControllerBase
    {
        private readonly ICustomerTypeService _CustomerTypeService;

        public CustomerTypeController(ICustomerTypeService CustomerTypeService)
        {
            _CustomerTypeService = CustomerTypeService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var CustomerTypes = await _CustomerTypeService.GetAll();
            return Ok(CustomerTypes);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var CustomerType = await _CustomerTypeService.GetById(id);
            if (CustomerType == null)
                return BadRequest("Not Found");
            return Ok(CustomerType);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CustomerTypeDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var CustomerType = new CustomerType()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                MainAccountId = dto.MainAccountId,
                Active = dto.Active,
                IsDeleted = false
            };
            await _CustomerTypeService.Add(CustomerType);

            return Ok(CustomerType);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(CustomerTypeDto dto, int id)
        {
            var CustomerType = await _CustomerTypeService.GetById(id);
            if (CustomerType == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                CustomerType.EnglishName = dto.EnglishName;
                CustomerType.ArabicName = dto.ArabicName;
                CustomerType.Description = dto.Description;
                CustomerType.Active = dto.Active;
                CustomerType.IsDeleted = dto.IsDeleted;
                CustomerType.MainAccountId = dto.MainAccountId;
                _CustomerTypeService.Update(CustomerType);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_CustomerTypeService.CustomerTypeExists(CustomerType.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(CustomerType);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var CustomerType = await _CustomerTypeService.GetById(id);
            if (CustomerType == null)
                return BadRequest("Not Found");
            _CustomerTypeService.Delete(CustomerType);
            return Ok(CustomerType);
        }
    }
}
