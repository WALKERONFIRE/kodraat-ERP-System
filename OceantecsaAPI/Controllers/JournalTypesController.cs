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
	public class JournalTypesController : ControllerBase
	{
		private readonly IJournalTypesService _journalTypesService;
		private readonly IMapper _mapper;
		public JournalTypesController(IJournalTypesService journalTypesService, IMapper mapper)
		{
			_journalTypesService = journalTypesService;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var types = await _journalTypesService.GetAll();
			return Ok(types);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var type = await _journalTypesService.GetById(id);
			if (type == null)
			{
				return NotFound();
			}
			return Ok(type);
		}

		[HttpPost]
		public async Task<IActionResult> CreateAsync(JournalTypeDto dto)
		{
			var data = _mapper.Map<JournalType>(dto);
			await _journalTypesService.Add(data);
			return Ok(data);
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			var type = await _journalTypesService.GetById(id);
			if (type == null)
			{
				return NotFound($"Cannot found this type with ID : {id}");
			}

			_journalTypesService.Delete(type);
			return Ok(type);
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAsync(int id, JournalTypeDto dto)
		{
			var type = await _journalTypesService.GetById(id);
			if (type == null)
			{
				return NotFound($"Cannot found this type with ID : {id}");
			}
			try
			{
				type.Id = dto.Id;
				type.ArabicName = dto.ArabicName;
				type.EnglishName = dto.EnglishName;				
				type.Description = dto.Description;
				type.Active = dto.Active;
				type.IsDeleted = dto.IsDeleted;
				_journalTypesService.Update(type);
				return Ok(type);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_journalTypesService.TypeExists(type.Id))
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
