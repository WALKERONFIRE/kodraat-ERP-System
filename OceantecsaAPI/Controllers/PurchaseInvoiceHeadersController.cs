using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOs;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.IdentityServices;
using Oceantecsa.Infrastructure.Interfaces;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PurchaseInvoiceHeadersController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IPurchaseInvoiceHdrsService _purchaseInvoiceHdrsService;
		private readonly IPurchaseInvoiceDtlsService _purchaseInvoiceDtlsService;
		private decimal total = 0; 
		public PurchaseInvoiceHeadersController(IMapper mapper, IPurchaseInvoiceHdrsService purchaseInvoiceHdrsService, IPurchaseInvoiceDtlsService purchaseInvoiceDtlsService)
		{
			_mapper = mapper;
			_purchaseInvoiceHdrsService = purchaseInvoiceHdrsService;
			_purchaseInvoiceDtlsService = purchaseInvoiceDtlsService;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var invoices = await _purchaseInvoiceHdrsService.GetAll();
			return Ok(invoices);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var invoice = await _purchaseInvoiceHdrsService.GetById(id);
			if (invoice == null)
			{
				return NotFound();
			}
			return Ok(invoice);
		}

		[HttpPost("AddInovice")]
		public async Task<IActionResult> CreateAsync(PurchaseInvoiceHdrDto dto)
		{
			var data = _mapper.Map<PurchaseInvoiceHdr>(dto);
			data.Posted = false;
			await _purchaseInvoiceHdrsService.Add(data);

			foreach (var item in dto.PurchaseInvoiceDtlDto)
			{
				PurchaseInvoiceDtl p = new PurchaseInvoiceDtl()
				{
					ProductId = item.ProductId,
					UnitId = item.UnitId,
					Quantity = item.Quantity,
					Price = item.Price,
					//DiscountPercent = item.DiscountPercent,
					DiscountValue = item.DiscountValue,
					//NetValue = item.NetValue,
					VatPercent = item.VatPercent,
					//VatValue = item.VatValue,
					//TotalValue = item.TotalValue,
					ProductDescription = item.ProductDescription,
					ReturnedQuantity = item.ReturnedQuantity,
					IsDeleted = item.IsDeleted,
				};
				p.PurchaseInvoiceHdrId = data.Id;

				p.NetValue = p.Price * p.Quantity;
				p.VatValue = p.NetValue * (p.VatPercent / 100);
				p.TotalValue = (p.NetValue - p.DiscountValue) + p.VatValue;
				//p.DiscountValue = p.NetValue * (p.DiscountPercent / 100);
				p.DiscountPercent = (p.DiscountValue / p.NetValue) * 100;
				
				await _purchaseInvoiceDtlsService.Add(p);

				data.OriginalValue += p.NetValue;
				data.VatValue+= p.VatValue;
			}
			//data.DiscountValue = data.OriginalValue * (data.DiscountPercent / 100);
			data.NetValue = data.OriginalValue - data.DiscountValue;
			data.DiscountPercent = (data.DiscountValue / data.OriginalValue) * 100;
			data.VatPercent = (data.VatValue / data.NetValue) * 100;
			data.InvoiceValue = (data.NetValue) + data.VatValue;
			return Ok(data);
		}

		[HttpPost("PostInovice")]
		public async Task<IActionResult> PostAsync(PurchaseInvoiceHdrDto dto)
		{
			var data = _mapper.Map<PurchaseInvoiceHdr>(dto);
			data.Posted = true;
			await _purchaseInvoiceHdrsService.Add(data);

			foreach (var item in dto.PurchaseInvoiceDtlDto)
			{
				PurchaseInvoiceDtl p = new PurchaseInvoiceDtl()
				{
					ProductId = item.ProductId,
					UnitId = item.UnitId,
					Quantity = item.Quantity,
					Price = item.Price,
					//DiscountPercent = item.DiscountPercent,
					DiscountValue = item.DiscountValue,
					//NetValue = item.NetValue,
					VatPercent = item.VatPercent,
					//VatValue = item.VatValue,
					//TotalValue = item.TotalValue,
					ProductDescription = item.ProductDescription,
					ReturnedQuantity = item.ReturnedQuantity,
					IsDeleted = item.IsDeleted,
				};
				p.PurchaseInvoiceHdrId = data.Id;

				p.NetValue = p.Price * p.Quantity;
				p.VatValue = p.NetValue * (p.VatPercent / 100);
				p.TotalValue = (p.NetValue - p.DiscountValue) + p.VatValue;
				//p.DiscountValue = p.NetValue * (p.DiscountPercent / 100);
				p.DiscountPercent = (p.DiscountValue / p.NetValue) * 100;

				await _purchaseInvoiceDtlsService.Add(p);

				data.OriginalValue += p.NetValue;
				data.VatValue += p.VatValue;
			}
			//data.DiscountValue = data.OriginalValue * (data.DiscountPercent / 100);
			data.NetValue = data.OriginalValue - data.DiscountValue;
			data.DiscountPercent = (data.DiscountValue / data.OriginalValue) * 100;
			data.VatPercent = (data.VatValue / data.NetValue) * 100;
			data.InvoiceValue = (data.NetValue) + data.VatValue;
			return Ok(data);
		}
		
		[HttpDelete]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			var Invoice = await _purchaseInvoiceHdrsService.GetById(id);
			if (Invoice == null)
			{
				return NotFound($"Cannot found this Invoice with ID : {id}");
			}
			if (Invoice.Posted == true)
			{
				return BadRequest("Cannot delete this Invoice!");
			}

			_purchaseInvoiceHdrsService.Delete(Invoice);
			return Ok(Invoice);
		}
		[HttpPut]
		public async Task<IActionResult> UpdateAsync(int id, PurchaseInvoiceHdrDto dto)
		{
			var Invoice = await _purchaseInvoiceHdrsService.GetById(id);
			if (Invoice == null)
			{
				return NotFound($"Cannot found this Currency with ID : {id}");
			}
			if (Invoice.Posted == true)
			{
				return BadRequest("Cannot Edit this journal!");
			}

			try
			{
				Invoice.Id = dto.Id;
				Invoice.PurchaseInvoiceId = dto.PurchaseInvoiceId;
				Invoice.TypeId = dto.TypeId;
				Invoice.BranchId = dto.BranchId;
				Invoice.WarehouseId = dto.WarehouseId;
				Invoice.SupplierId = dto.SupplierId;
				Invoice.SupplierInvoiceId = dto.SupplierInvoiceId;
				Invoice.PurchaseOrderId = dto.PurchaseOrderId;
				Invoice.CashBoxId = dto.CashBoxId;
				Invoice.BankAccountId = dto.BankAccountId;
				Invoice.InvoiceDate = dto.InvoiceDate;
				Invoice.InvoiceDescription = dto.InvoiceDescription;
				Invoice.OriginalValue = dto.OriginalValue;
				Invoice.DiscountPercent = dto.DiscountPercent;
				Invoice.DiscountValue = dto.DiscountValue;
				Invoice.NetValue = dto.NetValue;
				Invoice.LocationId = dto.LocationId;
				Invoice.VatPercent = dto.VatPercent;
				Invoice.VatValue = dto.VatValue;
				Invoice.InvoiceValue = dto.InvoiceValue;
				Invoice.PaidValue = dto.PaidValue;
				Invoice.CreatedDate = dto.CreatedDate;
				Invoice.CreatedUser = dto.CreatedUser;
				Invoice.ModifiedDate = dto.ModifiedDate;
				Invoice.ModifiedUser = dto.ModifiedUser;
				Invoice.PostedDate = dto.PostedDate;
				Invoice.PostedUser = dto.PostedUser;
				Invoice.IsDeleted = dto.IsDeleted;
				Invoice.Posted = true;
				_purchaseInvoiceHdrsService.Update(Invoice);

				foreach (var item in dto.PurchaseInvoiceDtlDto)
				{
					PurchaseInvoiceDtl p = new PurchaseInvoiceDtl()
					{
						ProductId = item.ProductId,
						UnitId = item.UnitId,
						Quantity = item.Quantity,
						Price = item.Price,
						//DiscountPercent = item.DiscountPercent,
						DiscountValue = item.DiscountValue,
						//NetValue = item.NetValue,
						VatPercent = item.VatPercent,
						//VatValue = item.VatValue,
						//TotalValue = item.TotalValue,
						ProductDescription = item.ProductDescription,
						ReturnedQuantity = item.ReturnedQuantity,
						IsDeleted = item.IsDeleted,
					};
					p.PurchaseInvoiceHdrId = Invoice.Id;

					p.NetValue = p.Price * p.Quantity;
					p.VatValue = p.NetValue * (p.VatPercent / 100);
					p.TotalValue = (p.NetValue - p.DiscountValue) + p.VatValue;
					//p.DiscountValue = p.NetValue * (p.DiscountPercent / 100);
					p.DiscountPercent = (p.DiscountValue / p.NetValue) * 100;

					 _purchaseInvoiceDtlsService.Update(p);

					Invoice.OriginalValue += p.NetValue;
					Invoice.VatValue += p.VatValue;
				}
				//data.DiscountValue = data.OriginalValue * (data.DiscountPercent / 100);
				Invoice.NetValue = Invoice.OriginalValue - Invoice.DiscountValue;
				Invoice.DiscountPercent = (Invoice.DiscountValue / Invoice.OriginalValue) * 100;
				Invoice.VatPercent = (Invoice.VatValue / Invoice.NetValue) * 100;
				Invoice.InvoiceValue = (Invoice.NetValue) + Invoice.VatValue;
				return Ok(Invoice);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_purchaseInvoiceHdrsService.PurchaseInvoiceHeaderExists(Invoice.Id))
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
