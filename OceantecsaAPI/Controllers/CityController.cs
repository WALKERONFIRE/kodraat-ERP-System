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
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var Cities = await _cityService.GetAll();
            return Ok(Cities);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var city = await _cityService.GetById(id);
            if (city == null)
                return BadRequest("Not Found");
            return Ok(city);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CityDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var city = new City()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                StateId = dto.StateId,
                Description = dto.Description,
                Active = dto.Active,

                IsDeleted = false
            };
            await _cityService.Add(city);

            return Ok(city);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(CityDto dto, int id)
        {
            var city = await _cityService.GetById(id);
            if (city == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                city.EnglishName = dto.EnglishName;
                city.ArabicName = dto.ArabicName;
                city.Description = dto.Description;
                city.StateId = dto.StateId;
                city.Active = dto.Active;
                _cityService.Update(city);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_cityService.CityExists(city.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(city);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var city = await _cityService.GetById(id);
            if (city == null)
                return BadRequest("Not Found");
            _cityService.Delete(city);
            return Ok(city);
        }
    }
}
