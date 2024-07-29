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
	public class SupplierTypesController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly ISupplierTypesService _supplierTypesService;
		public SupplierTypesController(IMapper mapper, ISupplierTypesService supplierTypesService)
		{
			_mapper = mapper;
			_supplierTypesService = supplierTypesService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var Types = await _supplierTypesService.GetAll();
			return Ok(Types);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var Type = await _supplierTypesService.GetById(id);
			if (Type == null)
			{
				return NotFound();
			}
			return Ok(Type);
		}

		[HttpPost]
		public async Task<IActionResult> CreateAsync(SupplierTypeDto dto)
		{
			var data = _mapper.Map<SupplierType>(dto);
			await _supplierTypesService.Add(data);
			return Ok(data);
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			var Type = await _supplierTypesService.GetById(id);
			if (Type == null)
			{
				return NotFound($"Cannot found this Type with ID : {id}");
			}

			_supplierTypesService.Delete(Type);
			return Ok(Type);
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAsync(int id, SupplierTypeDto dto)
		{
			var Type = await _supplierTypesService.GetById(id);
			if (Type == null)
			{
				return NotFound($"Cannot found this Type with ID : {id}");
			}
			try
			{
				
				Type.ArabicName = dto.ArabicName;
				Type.EnglishName = dto.EnglishName;
				Type.Description = dto.Description;
				Type.Active = dto.Active;
				Type.IsDeleted = dto.IsDeleted;
				Type.MainAccountId = dto.MainAccountId;
				_supplierTypesService.Update(Type);
				return Ok(Type);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_supplierTypesService.TypeExists(Type.Id))
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
