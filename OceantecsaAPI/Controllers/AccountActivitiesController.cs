using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOs;
using OceantecsaAPI.Services;
using System.Threading.Tasks;
namespace Zadbusiness.web.Controllers.Accounting
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountActivitiesController : ControllerBase
	{
		private readonly IAccountActivitiesServices _accountActivitiesServices;

		public AccountActivitiesController(IAccountActivitiesServices accountActivitiesServices)
		{
			_accountActivitiesServices = accountActivitiesServices;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var Activites = await _accountActivitiesServices.GetAll();
			return Ok(Activites);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(long? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var Activity = await _accountActivitiesServices.GetById(id);
			if (Activity == null)
			{
				return NotFound();
			}
			return Ok(Activity);
		}

		[HttpPost]
		public async Task<IActionResult> CreateAsync(AccountActivityDto dto)
		{
			//if (ModelState.IsValid)
			//{
			//	_context.Add(account);
			//	await _context.SaveChangesAsync();
			//	return RedirectToAction(nameof(Index));
			//}
			//return View(account);

			var activity = new AccountActivity()
			{
				Id=dto.Id,
			ParentId= dto.ParentId,
			ActivityLevel = dto.ActivityLevel,
			ArabicName = dto.ArabicName,
			Active = dto.Active,
			Description = dto.Description,
			EnglishName = dto.EnglishName,
			HaveSub = dto.HaveSub,
			IsDeleted= dto.IsDeleted,
			

		};
			await _accountActivitiesServices.Add(activity);

			return Ok(activity);
		}
		[HttpPut]
	
		public async Task<IActionResult> Update(AccountActivityDto dto , long id)
		{
			var account = await _accountActivitiesServices.GetById(id);
			if (account == null)
			{
				return NotFound($"Cannot found this account with ID : {id}");
			}
			try

			{
				
				account.ParentId = dto.ParentId;
				account.EnglishName = dto.EnglishName;
				account.ArabicName = dto.ArabicName;
				account.Description = dto.Description;
				account.Active = dto.Active;	
				account.HaveSub = dto.HaveSub;
				account.IsDeleted = dto.IsDeleted;
				account.ActivityLevel = dto.ActivityLevel;
				_accountActivitiesServices.Update(account);

			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_accountActivitiesServices.AccountExists(account.Id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}


			return Ok(account);
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteAccount(long id)
		{
			var account = await _accountActivitiesServices.GetById(id);
			if (account == null)
			{
				return NotFound($"Cannot found this account with ID : {id}");
			}
			_accountActivitiesServices.Delete(account);
			return Ok(account);
		}
	}
}
