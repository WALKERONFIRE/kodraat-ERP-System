using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System.Security.Cryptography.X509Certificates;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PurchaseReturnHeadersController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IPurchaseReturnHdrsService _purchaseReturnHdrsService;
		private readonly IPurchaseInvoiceHdrsService _purchaseInvoiceHdrsService;
		private readonly IPurchaseInvoiceDtlsService _purchaseInvoiceDtlsService;
		private readonly IPurchaseReturnDtlsService _purchaseReturnDtlsService;
		private readonly IDevelopERPContext _context;
		public PurchaseReturnHeadersController(IMapper mapper, IPurchaseReturnHdrsService purchaseReturnHdrsService, IPurchaseInvoiceHdrsService purchaseInvoiceHdrsService, IPurchaseInvoiceDtlsService purchaseInvoiceDtlsService, IPurchaseReturnDtlsService purchaseReturnDtlsService, IDevelopERPContext developERPContext)
		{
			_mapper = mapper;
			_purchaseReturnHdrsService = purchaseReturnHdrsService;
			_purchaseInvoiceHdrsService = purchaseInvoiceHdrsService;
			_purchaseInvoiceDtlsService = purchaseInvoiceDtlsService;
			_purchaseReturnDtlsService = purchaseReturnDtlsService;
			_context = developERPContext;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var purchaseReturns = await _purchaseReturnHdrsService.GetAll();
			return Ok(purchaseReturns);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var purchaseReturn = await _purchaseReturnHdrsService.GetById(id);
			if (purchaseReturn == null)
			{
				return NotFound();
			}
			return Ok(purchaseReturn);
		}

		[HttpGet("GetByPurchaseInvoiceId")]
		public async Task<IActionResult> GetByPurchaseInvoiceIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var purchaseReturn = await _purchaseInvoiceHdrsService.GetByPruchaseInvoiceId(id);
			if (purchaseReturn == null)
			{
				return NotFound();
			}
			return Ok(purchaseReturn);
		}

		[HttpGet("GetByBranchId")]
		public async Task<IActionResult> GetByBranchIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var purchaseReturns = await _purchaseInvoiceHdrsService.GetByBranchId(id);
			if (purchaseReturns == null)
			{
				return NotFound();
			}
			return Ok(purchaseReturns);
		}

		[HttpPut]
		public async Task<IActionResult> AddRetrunAsync(PurchaseReturnHdrDto dto)
		{
			
			var data = _mapper.Map<PurchaseReturnHdr>(dto);
			await _purchaseReturnHdrsService.Add(data);
			var invoice = await _purchaseInvoiceHdrsService.GetById(data.PurchaseInvoiceHdrId);
			var inv = _context.PurchaseInvoiceHdrs.Select(x => x.Id == data.PurchaseInvoiceHdrId);
			foreach (var item in dto.PurchaseReturnDtlDto)
			{
				var invoicedtl = _context.PurchaseInvoiceDtls.Where(x => x.PurchaseInvoiceHdrId == invoice.Id);
				PurchaseReturnDtl p = new PurchaseReturnDtl()
				{
					ReturnedQuantity = item.ReturnedQuantity,

				};
				foreach (var item2 in item.PurchaseInvoiceDtlDto)
				{
					PurchaseInvoiceDtl p2 = new PurchaseInvoiceDtl()
					{
						ReturnedQuantity = p.ReturnedQuantity,
						//
						// Quantity - ReturnedQuantity
						//

					};
					p2.PurchaseInvoiceHdrId = invoice.Id;
					p2.NetValue = p2.Price * (p2.Quantity - p2.ReturnedQuantity);
					p2.VatValue = p2.NetValue * (p2.VatPercent / 100);
					p2.TotalValue = (p2.NetValue - p2.DiscountValue) + p2.VatValue;
					p2.DiscountPercent = (p2.DiscountValue / p2.NetValue) * 100;
					_purchaseInvoiceDtlsService.Update(p2);
					invoice.OriginalValue += p2.NetValue;
					invoice.VatValue += p2.VatValue;
				}
				await _purchaseReturnDtlsService.Add(p);
			}

			invoice.NetValue = invoice.OriginalValue - invoice.DiscountValue;
			invoice.DiscountPercent = (invoice.DiscountValue / invoice.OriginalValue) * 100;
			invoice.VatPercent = (invoice.VatValue / invoice.NetValue) * 100;
			invoice.InvoiceValue = (invoice.NetValue) + invoice.VatValue;

			_purchaseInvoiceHdrsService.Update(invoice);
			
			return Ok(data);
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			var returnHdr = await _purchaseReturnHdrsService.GetById(id);
			if (returnHdr == null)
			{
				return NotFound($"Cannot found this return with ID : {id}");
			}
			_purchaseReturnHdrsService.Delete(returnHdr);
			return Ok(returnHdr);
		}
	}
}
