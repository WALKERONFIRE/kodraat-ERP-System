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
    public class SalesCashTypeController : ControllerBase
    {
        private readonly ISalesCashTypeService _SalesCashTypeService;

        public SalesCashTypeController(ISalesCashTypeService SalesCashTypeService)
        {
            _SalesCashTypeService = SalesCashTypeService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var SalesCashTypes = await _SalesCashTypeService.GetAll();
            return Ok(SalesCashTypes);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var SalesCashType = await _SalesCashTypeService.GetById(id);
            if (SalesCashType == null)
                return BadRequest("Not Found");
            return Ok(SalesCashType);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SalesCashTypeDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var SalesCashType = new SalesCashType()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                Active = dto.Active,
                IsBank              = dto.IsBank,
                BankAccountId       = dto.BankAccountId,
                CommissionAccountId = dto.CommissionAccountId,
                VatAccountId        = dto.VatAccountId ,
                CommissionPercent   = dto.CommissionPercent, 
                VatPercent          = dto.VatPercent ,
                IsDeleted = false
            };
            await _SalesCashTypeService.Add(SalesCashType);

            return Ok(SalesCashType);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(SalesCashTypeDto dto, int id)
        {
            var SalesCashType = await _SalesCashTypeService.GetById(id);
            if (SalesCashType == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                SalesCashType.EnglishName = dto.EnglishName;
                SalesCashType.ArabicName = dto.ArabicName; 
                SalesCashType.Description = dto.Description;
                SalesCashType.Active = dto.Active;
                SalesCashType.IsBank = dto.IsBank;
                SalesCashType.BankAccountId = dto.BankAccountId;
                SalesCashType.CommissionAccountId = dto.CommissionAccountId;
                SalesCashType.VatAccountId = dto.VatAccountId;
                SalesCashType.CommissionPercent = dto.CommissionPercent;
                SalesCashType.VatPercent = dto.VatPercent;
                SalesCashType.IsDeleted = dto.IsDeleted;
                _SalesCashTypeService.Update(SalesCashType);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_SalesCashTypeService.SalesCashTypeExists(SalesCashType.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(SalesCashType);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var SalesCashType = await _SalesCashTypeService.GetById(id);
            if (SalesCashType == null)
                return BadRequest("Not Found");
            _SalesCashTypeService.Delete(SalesCashType);
            return Ok(SalesCashType);
        }
    }
}
