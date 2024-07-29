using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.IdentityServices;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WarehousesController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IWarehousesService _warehousesService;
		public WarehousesController(IMapper mapper, IWarehousesService warehousesService)
		{
			_mapper = mapper;
			_warehousesService = warehousesService;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var Warehouses = await _warehousesService.GetAll();
			return Ok(Warehouses);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var Warehouse = await _warehousesService.GetById(id);
			if (Warehouse == null)
			{
				return NotFound();
			}
			return Ok(Warehouse);
		}

		[HttpPost]
		public async Task<IActionResult> CreateAsync(WarehouseDto dto)
		{
			var data = _mapper.Map<Warehouse>(dto);
			await _warehousesService.Add(data);
			return Ok(data);
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			var Type = await _warehousesService.GetById(id);
			if (Type == null)
			{
				return NotFound($"Cannot found this Warehouse with ID : {id}");
			}

			_warehousesService.Delete(Type);
			return Ok(Type);
		}
		
		[HttpPut]
		public async Task<IActionResult> UpdateAsync(int id, WarehouseDto dto)
		{
			var Warehouse = await _warehousesService.GetById(id);
			if (Warehouse == null)
			{
				return NotFound($"Cannot found this Warehouse with ID : {id}");
			}
			try
			{
				Warehouse.Id = dto.Id;
				Warehouse.ArabicName = dto.ArabicName;
				Warehouse.EnglishName = dto.EnglishName;
				Warehouse.Description = dto.Description;
				Warehouse.WarehouseTypeId = dto.WarehouseTypeId;
				Warehouse.BranchId = dto.BranchId;
				Warehouse.CostingTypeId = dto.CostingTypeId;
				Warehouse.AccountId= dto.AccountId;
				Warehouse.Active = dto.Active;
				Warehouse.IsDeleted = dto.IsDeleted;
				_warehousesService.Update(Warehouse);
				return Ok(Warehouse);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_warehousesService.WarehouseExists(Warehouse.Id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}
		}
	}
}
