using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOs;

using OceantecsaAPI.Services;
using Zadbusiness.web.Services;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CurrencyController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly ICurrenciesService _currenciesService;
		public CurrencyController(IMapper mapper, ICurrenciesService currenciesService)
		{
			_mapper = mapper;
			_currenciesService = currenciesService;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var currencies = await _currenciesService.GetAll();
			return Ok(currencies);
		}


		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var Currency = await _currenciesService.GetById(id);
			if (Currency == null)
			{
				return NotFound();
			}
			return Ok(Currency);
		}
		[HttpPost]
		public async Task<IActionResult> CreateAsync(CurrencyDto dto)
		{
			var data = _mapper.Map<Currency>(dto);
			await _currenciesService.Add(data);
			return Ok(data);
		}
		[HttpPut]
		public async Task<IActionResult> UpdateAsync(int id , CurrencyDto dto)
		{
			var currency = await _currenciesService.GetById(id);
			if (currency == null)
			{
				return NotFound($"Cannot found this Currency with ID : {id}");
			}
			try
			{
				currency.Id = dto.Id;
				currency.ArabicName = dto.ArabicName;
				currency.EnglishName = dto.EnglishName;
				currency.ArabicDigit = dto.ArabicDigit;
				currency.EnglishDigit = dto.EnglishDigit;
				currency.Description = dto.Description;				
				currency.Active=dto.Active;	
				currency.CurrencyRate=dto.CurrencyRate;		
				currency.MainCurrency=dto.MainCurrency;
				currency.IsDeleted=dto.IsDeleted;
				_currenciesService.Update(currency);
				return Ok(currency);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_currenciesService.CurrencyExists(currency.Id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			var currency = await _currenciesService.GetById(id);
			if (currency == null)
			{
				return NotFound($"Cannot found this Currency with ID : {id}");
			}

			_currenciesService.Delete(currency);
			return Ok(currency);
		}

	}
}
