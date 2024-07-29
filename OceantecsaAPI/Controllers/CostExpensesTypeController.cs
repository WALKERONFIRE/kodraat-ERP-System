using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOs;
using OceantecsaAPI.Services;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CostExpensesTypeController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly ICostExpensesTypesService _costExpensesTypesService;

		public CostExpensesTypeController(IMapper mapper, ICostExpensesTypesService costExpensesTypesService)
		{
			_mapper = mapper;
			_costExpensesTypesService = costExpensesTypesService;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var Types = await _costExpensesTypesService.GetAll();
			return Ok(Types);
		}
		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var Type = await _costExpensesTypesService.GetById(id);
			if (Type == null)
			{
				return NotFound();
			}
			return Ok(Type);
		}
		[HttpPost]
		public async Task<IActionResult> CreateAsync(CostExpensesTypeDto dto)
		{
			var data = _mapper.Map<CostExpensesType>(dto);
			await _costExpensesTypesService.Add(data);
			return Ok(data);
		}
		[HttpPut]
		public async Task<IActionResult> UpdateAsync(int id, CurrencyDto dto)
		{
			var Type = await _costExpensesTypesService.GetById(id);
			if (Type == null)
			{
				return NotFound($"Cannot found this Type with ID : {id}");
			}
			try
			{
				Type.Id = dto.Id;
				Type.ArabicName = dto.ArabicName;
				Type.EnglishName = dto.EnglishName;
				Type.Description = dto.Description;
				Type.Active = dto.Active;
				Type.IsDeleted = dto.IsDeleted;
				_costExpensesTypesService.Update(Type);
				return Ok(Type);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_costExpensesTypesService.CostExpensesTypeExists(Type.Id))
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
			var Type = await _costExpensesTypesService.GetById(id);
			if (Type == null)
			{
				return NotFound($"Cannot found this Type with ID : {id}");
			}

			_costExpensesTypesService.Delete(Type);
			return Ok(Type);
		}
	}
}
