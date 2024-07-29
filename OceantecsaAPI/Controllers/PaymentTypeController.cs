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
    public class PaymentTypeController : ControllerBase
    {
        private readonly IPaymentTypeService _paymentTypeService;

        public PaymentTypeController(IPaymentTypeService paymentTypeService)
        {
            _paymentTypeService = paymentTypeService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var paymentTypes = await _paymentTypeService.GetAll();
            return Ok(paymentTypes);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var paymentTypes = await _paymentTypeService.GetById(id);
            if (paymentTypes == null)
                return BadRequest("Not Found");
            return Ok(paymentTypes);
        }
        [HttpPost]
        public async Task<IActionResult> Create(PaymentTypeDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var paymentType = new PaymentType()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                Active = dto.Active,
                IsDeleted = false
            };
            await _paymentTypeService.Add(paymentType);

            return Ok(paymentType);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(PaymentTypeDto dto, int id)
        {
            var paymentType = await _paymentTypeService.GetById(id);
            if (paymentType == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                paymentType.EnglishName = dto.EnglishName;
                paymentType.ArabicName = dto.ArabicName;
                paymentType.Description = dto.Description;
                paymentType.Active = dto.Active;
                _paymentTypeService.Update(paymentType);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_paymentTypeService.PaymentTypeExists(paymentType.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(paymentType);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var paymentType = await _paymentTypeService.GetById(id);
            if (paymentType == null)
                return BadRequest("Not Found");
            _paymentTypeService.Delete(paymentType);
            return Ok(paymentType);
        }
    }
}
