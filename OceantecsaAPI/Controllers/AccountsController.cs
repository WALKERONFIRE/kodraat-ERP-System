using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

using System.Linq;
using System.Net.Sockets;
using OceantecsaAPI.Services;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOs;
using AutoMapper;
using Oceantecsa.Persistence.DataContext;
using Oceantecsa.Infrastructure.Filters;
using Oceantecsa.Infrastructure.Wrappers;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountsController : ControllerBase
	{
		
		private readonly IAccountsService _accountsService;
		private readonly IMapper _mapper;
	
		public AccountsController(IAccountsService accountsService, IMapper mapper, IDevelopERPContext context)
		{
			_accountsService = accountsService;
			_mapper = mapper;
		
		}
		[HttpGet("Page")]
		public async Task<IActionResult> GetAllPaged(int pageNumber , float pageSize)
		{			
			var accounts = await _accountsService.GetAllPaged(pageNumber, pageSize);
			return Ok(accounts);
		}
		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var Accounts = await _accountsService.GetAll();
			return Ok(Accounts);
		}
		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(long? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var Account = await _accountsService.GetById(id);
			if (Account == null)
			{
				return NotFound();
			}
			return Ok(Account);
		}
		[HttpPost]
		
		public async Task<IActionResult> Create(CreateAccountDto dto)
		{
			//if (ModelState.IsValid)
			//{
			//	_context.Add(account);
			//	await _context.SaveChangesAsync();
			//	return RedirectToAction(nameof(Index));
			//}
			//return View(account);
		var data = _mapper.Map<Account>(dto);	
			await _accountsService.Add(data);
			
			return Ok(data);
		}
		[HttpPut]
		
		public async Task<IActionResult> Update(CreateAccountDto dto, long id)
		{
			var account = await _accountsService.GetById(id);
			if (account == null)
			{
				return NotFound($"Cannot found this account with ID : {id}");
			}
			try

			{
				account.Id = id;
				account.ParentId = dto.ParentId;
				account.EnglishName = dto.EnglishName;
				account.ArabicName = dto.ArabicName;
				account.Description = dto.Description;
				account.AccountActivityId = dto.AccountActivityId;
				account.AccountAnalysisTypeId = dto.AccountAnalysisTypeId;
				account.AccountCloseTypeId = dto.AccountCloseTypeId;
				account.AccountGroupId = dto.AccountGroupId;
				account.AccountLevel = dto.AccountLevel;
				account.AccountTypeId = dto.AccountTypeId;
				account.Active = dto.Active;
				account.CashFlowTypeId = dto.CashFlowTypeId;
				account.CostCenterId = dto.CostCenterId;
				account.CostCategoryTypeId = dto.CostCategoryTypeId;
				account.CreatedDate = dto.CreatedDate;
				account.DirectCashFlowTypeId = dto.DirectCashFlowTypeId;
				account.CostExpensesTypeId = dto.CostExpensesTypeId;
				account.FinancialStatmentTypeId = dto.FinancialStatmentTypeId;
				account.GeneralExpenseTypeId = dto.GeneralExpenseTypeId;
				account.HaveAccountActivity = dto.HaveAccountActivity;
				account.HaveAccountAnalysis = dto.HaveAccountAnalysis;
				account.HaveCostCenter = dto.HaveCostCenter;
				account.HaveSub = dto.HaveSub;
				account.IsDeleted = dto.IsDeleted;
				account.ManufacturingCostTypeId = dto.ManufacturingCostTypeId;
				_accountsService.Update(account);
				
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_accountsService.AccountExists(account.Id))
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
			var account = await _accountsService.GetById(id);
			if (account == null)
			{
				return NotFound($"Cannot found this account with ID : {id}");
			}

			_accountsService.Delete(account);
			return Ok(account);
		}
		//private bool AccountExists(long id)
		//{
		//	return _context.Accounts.Any(e => e.Id == id);
		//}
	}


	}




