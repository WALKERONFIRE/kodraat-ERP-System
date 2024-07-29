using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.IdentityServices;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;

namespace OceantecsaAPI.Controllers
{

	[Route("CashBoxTransactionsHdrController")]
	[ApiController]
	public class CashBoxTransactionsHdrController : ControllerBase
	{
		private readonly ICashboxTransactionHdrsService _cashboxTransactionHdrsService;
		private readonly IMapper _mapper;
		private readonly ICashboxTransactionDtlsService _cashboxTransactionDtlsService;
		public CashBoxTransactionsHdrController(IDevelopERPContext context, IMapper mapper, ICashboxTransactionHdrsService cashboxTransactionHdrsService, ICashboxTransactionDtlsService cashboxTransactionDtlsService)
		{

			_mapper = mapper;
			_cashboxTransactionHdrsService = cashboxTransactionHdrsService;
			_cashboxTransactionDtlsService = cashboxTransactionDtlsService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var cashboxTransactionHdrs = await _cashboxTransactionHdrsService.GetAll();
			return Ok(cashboxTransactionHdrs);
		}

		[HttpGet("Page")]
		public async Task<IActionResult> GetAllPaged(int pageNumber, float pageSize)
		{
			var cashboxTransactionHdrs = await _cashboxTransactionHdrsService.GetAllPaged(pageNumber, pageSize);
			return Ok(cashboxTransactionHdrs);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(long? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var cashboxTransactionHdr = await _cashboxTransactionHdrsService.GetById(id);
			if (cashboxTransactionHdr == null)
			{
				return NotFound();
			}
			return Ok(cashboxTransactionHdr);
		}
		[HttpPost]
		public async Task<IActionResult> CreateAsync(CashBoxTransactionsHdrDTO dto)
		{
			var data = _mapper.Map<CashBoxTransactionsHdr>(dto);
			await _cashboxTransactionHdrsService.Add(data);
			foreach (var item in dto.CashBoxTransactionsDtlDTO)
			{
				CashBoxTransactionsDtl c = new CashBoxTransactionsDtl()
				{
					AccountId = item.AccountId,
					AccountAnalysisId = item.AccountAnalysisId,
					AccountActivityId = item.AccountActivityId,
					CostCenterId = item.CostCenterId,
					CurrencyId = item.CurrencyId,
					LocalDebit = item.LocalDebit,
					LocalCredit = item.LocalCredit,
					CurrencyRate = item.CurrencyRate,
					ForeignDebit = item.ForeignDebit,
					ForeignCredit = item.ForeignCredit,
					Description = item.Description
				};

				c.CashBoxTransactionsHdrId = data.Id;
				c.CashBoxTransactionsId= data.Id;
				await _cashboxTransactionDtlsService.Add(c);

			}
			return Ok(data);
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			var cashboxTransactionHdr = await _cashboxTransactionHdrsService.GetById(id);
			if (cashboxTransactionHdr == null)
			{
				return NotFound($"Cannot found this Transaction with ID : {id}");
			}

			_cashboxTransactionHdrsService.Delete(cashboxTransactionHdr);
			return Ok(cashboxTransactionHdr);
		}
		[HttpPut]
		public async Task<IActionResult> UpdateAsync(int id, CashBoxTransactionsHdrDTO dto)
		{
			var Hdr = await _cashboxTransactionHdrsService.GetById(id);
			if (Hdr == null)
			{
				return NotFound($"Cannot found this Transaction with ID : {id}");
			}
			try
			{
				Hdr.Id = dto.Id;
				Hdr.BankAccountId = dto.BankAccountId;
				Hdr.BranchId = dto.BranchId;
				Hdr.JournalId = dto.JournalId;
				Hdr.PurchaseInvoiceId = dto.PurchaseInvoiceId;
				Hdr.SalesInvoiceId = dto.SalesInvoiceId;
				Hdr.Active = dto.Active;
				Hdr.CurrencyId = dto.CurrencyId;
				Hdr.CurrencyRate = dto.CurrencyRate;
				Hdr.CreatedDate = dto.CreatedDate;
				Hdr.CashBoxId = dto.CashBoxId;
				Hdr.LocalValue = dto.LocalValue;
				Hdr.ForeignValue = dto.ForeignValue;
				Hdr.TransactionDate = dto.TransactionDate;
				Hdr.Description = dto.Description;
				Hdr.TransactionTypeId = dto.TransactionTypeId;
				Hdr.ReceiptTypeId = dto.ReceiptTypeId;
				Hdr.PaymentTypeId = dto.PaymentTypeId;
				Hdr.CustomerId = dto.CustomerId;
				Hdr.SalesOrderId = dto.SalesOrderId;
				Hdr.SupplierId = dto.SupplierId;
				Hdr.CreatedDate = dto.CreatedDate;
				Hdr.CreatedUser = dto.CreatedUser;
				Hdr.ModifiedDate = dto.ModifiedDate;
				Hdr.ModifiedUser = dto.ModifiedUser;
				Hdr.PostedDate = dto.PostedDate;
				Hdr.PostedUser = dto.PostedUser;
				Hdr.Posted = dto.Posted;
				Hdr.IsDeleted = dto.IsDeleted;
				Hdr.BankAccountId = dto.BankAccountId;
				_cashboxTransactionHdrsService.Update(Hdr);
				foreach (var item in dto.CashBoxTransactionsDtlDTO)
				{
					CashBoxTransactionsDtl c = new CashBoxTransactionsDtl()
					{
						AccountId = item.AccountId,
						AccountAnalysisId = item.AccountAnalysisId,
						AccountActivityId = item.AccountActivityId,
						CostCenterId = item.CostCenterId,
						CurrencyId = item.CurrencyId,
						LocalDebit = item.LocalDebit,
						LocalCredit = item.LocalCredit,
						CurrencyRate = item.CurrencyRate,
						ForeignDebit = item.ForeignDebit,
						ForeignCredit = item.ForeignCredit,
						Description = item.Description
					};

					c.CashBoxTransactionsHdrId = Hdr.Id;
					_cashboxTransactionDtlsService.Update(c);
					
				}
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_cashboxTransactionHdrsService.CashboxTransactionHdrExists(Hdr.Id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}
			return Ok(Hdr);
		}

	}
}
