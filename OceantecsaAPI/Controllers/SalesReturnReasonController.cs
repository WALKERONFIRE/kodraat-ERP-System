using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesReturnReasonController : ControllerBase
    {
        private readonly ISalesReturnReasonService _SalesReturnReasonService;

        public SalesReturnReasonController(ISalesReturnReasonService SalesReturnReasonService)
        {
            _SalesReturnReasonService = SalesReturnReasonService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var SalesReturnReasons = await _SalesReturnReasonService.GetAll();
            return Ok(SalesReturnReasons);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var SalesReturnReason = await _SalesReturnReasonService.GetById(id);
            if (SalesReturnReason == null)
                return BadRequest("Not Found");
            return Ok(SalesReturnReason);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SalesReturnReasonDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var SalesReturnReason = new SalesReturnReason()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                Active = dto.Active,
                IsDeleted = false
            };
            await _SalesReturnReasonService.Add(SalesReturnReason);

            return Ok(SalesReturnReason);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(SalesReturnReasonDto dto, int id)
        {
            var SalesReturnReason = await _SalesReturnReasonService.GetById(id);
            if (SalesReturnReason == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                SalesReturnReason.EnglishName = dto.EnglishName;
                SalesReturnReason.ArabicName = dto.ArabicName;
                SalesReturnReason.Description = dto.Description;
                SalesReturnReason.Active = dto.Active;
                SalesReturnReason.IsDeleted = dto.IsDeleted;
                _SalesReturnReasonService.Update(SalesReturnReason);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_SalesReturnReasonService.SalesReturnReasonExists(SalesReturnReason.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(SalesReturnReason);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var SalesReturnReason = await _SalesReturnReasonService.GetById(id);
            if (SalesReturnReason == null)
                return BadRequest("Not Found");
            _SalesReturnReasonService.Delete(SalesReturnReason);
            return Ok(SalesReturnReason);
        }
    }
}
