using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.IdentityServices;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerActivityController : ControllerBase
    {
        private readonly ICustomerActivitySevice _CustomerActivityService;

        public CustomerActivityController(ICustomerActivitySevice CustomerActivityService)
        {
            _CustomerActivityService = CustomerActivityService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var CustomerActivitys = await _CustomerActivityService.GetAll();
            return Ok(CustomerActivitys);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var CustomerActivity = await _CustomerActivityService.GetById(id);
            if (CustomerActivity == null)
                return BadRequest("Not Found");
            return Ok(CustomerActivity);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CustomerActivityDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var CustomerActivity = new CustomerActivity()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                Active = dto.Active,
                IsDeleted = false
            };
            await _CustomerActivityService.Add(CustomerActivity);

            return Ok(CustomerActivity);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(CustomerActivityDto dto, int id)
        {
            var CustomerActivity = await _CustomerActivityService.GetById(id);
            if (CustomerActivity == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                CustomerActivity.EnglishName = dto.EnglishName;
                CustomerActivity.ArabicName = dto.ArabicName;
                CustomerActivity.Description = dto.Description;
                CustomerActivity.Active = dto.Active;
                CustomerActivity.IsDeleted = dto.IsDeleted;
                _CustomerActivityService.Update(CustomerActivity);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_CustomerActivityService.CustomerActivityExists(CustomerActivity.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(CustomerActivity);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var CustomerActivity = await _CustomerActivityService.GetById(id);
            if (CustomerActivity == null)
                return BadRequest("Not Found");
            _CustomerActivityService.Delete(CustomerActivity);
            return Ok(CustomerActivity);
        }
    }
}
