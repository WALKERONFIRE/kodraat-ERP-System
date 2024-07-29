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
    public class CustomerGroupController : ControllerBase
    {
        private readonly ICustomerGroupService _CustomerGroupService;

        public CustomerGroupController(ICustomerGroupService CustomerGroupService)
        {
            _CustomerGroupService = CustomerGroupService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var CustomerGroups = await _CustomerGroupService.GetAll();
            return Ok(CustomerGroups);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var CustomerGroup = await _CustomerGroupService.GetById(id);
            if (CustomerGroup == null)
                return BadRequest("Not Found");
            return Ok(CustomerGroup);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CustomerGroupDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var CustomerGroup = new CustomerGroup()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                MainAccountId = dto.MainAccountId,
                Active = dto.Active,
                IsDeleted = false
            };
            await _CustomerGroupService.Add(CustomerGroup);

            return Ok(CustomerGroup);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(CustomerGroupDto dto, int id)
        {
            var CustomerGroup = await _CustomerGroupService.GetById(id);
            if (CustomerGroup == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                CustomerGroup.EnglishName = dto.EnglishName;
                CustomerGroup.ArabicName = dto.ArabicName;
                CustomerGroup.Description = dto.Description;
                CustomerGroup.Active = dto.Active;
                CustomerGroup.IsDeleted = dto.IsDeleted;
                CustomerGroup.MainAccountId = dto.MainAccountId;
                _CustomerGroupService.Update(CustomerGroup);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_CustomerGroupService.CustomerGroupExists(CustomerGroup.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(CustomerGroup);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var CustomerGroup = await _CustomerGroupService.GetById(id);
            if (CustomerGroup == null)
                return BadRequest("Not Found");
            _CustomerGroupService.Delete(CustomerGroup);
            return Ok(CustomerGroup);
        }
    }
}
