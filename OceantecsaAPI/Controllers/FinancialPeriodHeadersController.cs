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
	public class FinancialPeriodHeadersController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IFinancialPeriodHdrsService _financialPeriodHdrsService;

		public FinancialPeriodHeadersController(IMapper mapper, IFinancialPeriodHdrsService financialPeriodHdrsService)
		{
			_mapper = mapper;
			_financialPeriodHdrsService = financialPeriodHdrsService;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var Periods = await _financialPeriodHdrsService.GetAll();
			return Ok(Periods);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var Period = await _financialPeriodHdrsService.GetById(id);
			if (Period == null)
			{
				return NotFound();
			}
			return Ok(Period);
		}
		[HttpPost]
		public async Task<IActionResult> CreateAsync(FinancialPeriodHdrDto dto)
		{
			var data = _mapper.Map<FinancialPeriodHdr>(dto);
			await _financialPeriodHdrsService.Add(data);
			return Ok(data);
		}
		[HttpPut]
		public async Task<IActionResult> UpdateAsync(int id, FinancialPeriodHdrDto dto)
		{
			var Period = await _financialPeriodHdrsService.GetById(id);
			if (Period == null)
			{
				return NotFound($"Cannot found this Currency with ID : {id}");
			}
			try
			{
				Period.Id = dto.Id;
				Period.CompanyId = dto.CompanyId;
				Period.Year = dto.Year;
				Period.Count = dto.Count;
				Period.PeriodStart = dto.PeriodStart;
				Period.PeriodEnd = dto.PeriodEnd;
				Period.Description = dto.Description;
				Period.Posted = dto.Posted;
				Period.Locked = dto.Locked;
				Period.CreatedDate = dto.CreatedDate;
				Period.CreatedUser = dto.CreatedUser;
				Period.ModifiedDate = dto.ModifiedDate;
				Period.ModifiedUser = dto.ModifiedUser;
				Period.PostedDate = dto.PostedDate;
				Period.PostedUser = dto.PostedUser;
				Period.Active = dto.Active;
				Period.IsDeleted = dto.IsDeleted;

				_financialPeriodHdrsService.Update(Period);

				return Ok(Period);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_financialPeriodHdrsService.FinancialPeriodHeaderExists(Period.Id))
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
			var currency = await _financialPeriodHdrsService.GetById(id);
			if (currency == null)
			{
				return NotFound($"Cannot found this Currency with ID : {id}");
			}

			_financialPeriodHdrsService.Delete(currency);
			return Ok(currency);
		}

	}
}
