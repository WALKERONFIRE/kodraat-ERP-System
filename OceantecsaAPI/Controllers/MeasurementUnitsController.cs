using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOs;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementUnitsController : ControllerBase
    {
        private readonly IMeasurementUnitsService _measurementUnitsService;
        public MeasurementUnitsController(IMeasurementUnitsService measurementUnitsService)
        {
           _measurementUnitsService = measurementUnitsService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var measurementUnits = await _measurementUnitsService.GetAll();
            return Ok(measurementUnits);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var measurementUnit = await _measurementUnitsService.GetById(id);
            if (measurementUnit == null)
                return BadRequest("Not Found");
            return Ok(measurementUnit);
        }
        [HttpPost]
        public async Task<IActionResult> Create(MeasurementUnitsDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var measurementUnit = new MeasurementUnit()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                Active = dto.Active,
                IsDeleted = false
            };
            await _measurementUnitsService.Add(measurementUnit);

            return Ok(measurementUnit);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(MeasurementUnitsDto dto, int id)
        {
            var measurementUnit = await _measurementUnitsService.GetById(id);
            if (measurementUnit == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                measurementUnit.EnglishName = dto.EnglishName;
                measurementUnit.ArabicName = dto.ArabicName;
                measurementUnit.Description = dto.Description;
                measurementUnit.Active = dto.Active;
                _measurementUnitsService.Update(measurementUnit);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_measurementUnitsService.MeasurementUnitExists(measurementUnit.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(measurementUnit);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var measurementUnit = await _measurementUnitsService.GetById(id);
            if (measurementUnit == null)
                return BadRequest("Not Found");
            _measurementUnitsService.Delete(measurementUnit);
            return Ok(measurementUnit);
        }
    }
}
