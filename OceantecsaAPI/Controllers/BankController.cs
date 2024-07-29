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
    public class BankController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var Banks = await _bankService.GetAll();
            return Ok(Banks);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var bank = await _bankService.GetById(id);
            if (bank == null)
                return BadRequest("Not Found");
            return Ok(bank);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BankDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var bank = new Bank()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                Active = dto.Active,
                IsDeleted = false
            };
            await _bankService.Add(bank);

            return Ok(bank);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(BankDto dto, int id)
        {
            var bank = await _bankService.GetById(id);
            if (bank == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                bank.EnglishName = dto.EnglishName;
                bank.ArabicName = dto.ArabicName;
                bank.Description = dto.Description;
                bank.Active = dto.Active;
                _bankService.Update(bank);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_bankService.BankExists(bank.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(bank);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var bank = await _bankService.GetById(id);
            if (bank == null)
                return BadRequest("Not Found");
            _bankService.Delete(bank);
            return Ok(bank);
        }
    }
}
