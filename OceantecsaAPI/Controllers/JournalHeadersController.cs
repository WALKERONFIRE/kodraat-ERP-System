using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOs;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using OceantecsaAPI.Services;
using System.Reflection.PortableExecutable;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class JournalHeadersController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IJournalHeadersService _journalHeadersService;

		public JournalHeadersController(IMapper mapper, IJournalHeadersService journalHeadersService)
		{
			_mapper = mapper;
			_journalHeadersService = journalHeadersService;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var Headers = await _journalHeadersService.GetAll();
			return Ok(Headers);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var Header = await _journalHeadersService.GetById(id);
			if (Header == null)
			{
				return NotFound();
			}
			return Ok(Header);
		}

		[HttpPost("AddJournal")]
		public async Task<IActionResult> CreateAsync(JournalHdrDto dto)
		{
			var data = _mapper.Map<JournalHdr>(dto);
			await _journalHeadersService.Add(data);
			data.Posted = false;
			return Ok(data);
		}
		[HttpPost("PostJournal")]
		public async Task<IActionResult> PostAsync(JournalHdrDto dto)
		{
			var data = _mapper.Map<JournalHdr>(dto);
			await _journalHeadersService.Add(data);
			data.Posted = true;
			return Ok(data);
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			var Header = await _journalHeadersService.GetById(id);
			if (Header == null)
			{
				return NotFound($"Cannot found this Journal with ID : {id}");
			}
			if (Header.Posted == true)
			{
				return BadRequest("Cannot delete this journal!");
			}

			_journalHeadersService.Delete(Header);
			return Ok(Header);
		}
		[HttpPut]
		public async Task<IActionResult> UpdateAsync(int id, JournalHdrDto dto)
		{
			var Header = await _journalHeadersService.GetById(id);
			if (Header == null)
			{
				return NotFound($"Cannot found this Currency with ID : {id}");
			}
			if (Header.Posted == true)
			{
				return BadRequest("Cannot Edit this journal!");
			}

			try
			{
				Header.Id = dto.Id;
				Header.Manual = dto.Manual;
				Header.TotalDebit = dto.TotalDebit;
				Header.TotalCredit = dto.TotalCredit;
				Header.BranchId= dto.BranchId;
				Header.JournalNotesAr= dto.JournalNotesAr;
				Header.JournalNotesEn= dto.JournalNotesEn;
				Header.UserManualId = dto.UserManualId;
				Header.TransactionDate = dto.TransactionDate;
				Header.CreatedDate = dto.CreatedDate;
				Header.CreatedUser = dto.CreatedUser;
				Header.ModifiedDate = dto.ModifiedDate;
				Header.ModifiedUser = dto.ModifiedUser;
				Header.PostedDate = dto.PostedDate;
				Header.PostedUser = dto.PostedUser;
				Header.Active = dto.Active;
				Header.IsDeleted = dto.IsDeleted;
				Header.TransactionSerial= dto.TransactionSerial;
				Header.TransactionId = dto.TransactionId;
				Header.ManualId= dto.ManualId;
				Header.TransactionTypeId = dto.TransactionTypeId;
				Header.UserManualId = dto.UserManualId;
				Header.JournalTypeId = dto.JournalTypeId;
				_journalHeadersService.Update(Header);

				return Ok(Header);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_journalHeadersService.JounralExists(Header.Id))
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
