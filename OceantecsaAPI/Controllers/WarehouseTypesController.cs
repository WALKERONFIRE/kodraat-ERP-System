using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOs;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WarehouseTypesController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IWarehouseTypesService _warehouseTypesService;
		public WarehouseTypesController(IMapper mapper, IWarehouseTypesService warehouseTypesService)
		{
			_mapper = mapper;
			_warehouseTypesService = warehouseTypesService;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var Types = await _warehouseTypesService.GetAll();
			return Ok(Types);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var Type = await _warehouseTypesService.GetById(id);
			if (Type == null)
			{
				return NotFound();
			}
			return Ok(Type);
		}

		[HttpPost]
		public async Task<IActionResult> CreateAsync(WarehouseTypeDto dto)
		{
			var data = _mapper.Map<WarehouseType>(dto);
			await _warehouseTypesService.Add(data);
			return Ok(data);
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAsync(int id, WarehouseTypeDto dto)
		{
			var Type = await _warehouseTypesService.GetById(id);
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
				_warehouseTypesService.Update(Type);
				return Ok(Type);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_warehouseTypesService.TypeExists(Type.Id))
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
			var Type = await _warehouseTypesService.GetById(id);
			if (Type == null)
			{
				return NotFound($"Cannot found this Type with ID : {id}");
			}

			_warehouseTypesService.Delete(Type);
			return Ok(Type);
		}
	}
}
