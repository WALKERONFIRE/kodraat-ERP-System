using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using Oceantecsa.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
	public class SupplierReportsService : ISupplierReportsService
	{
		private readonly IDevelopERPContext	_context;

		public SupplierReportsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<(List<SupplierBalanceReportDTO>, decimal, decimal, decimal)> GetFilteredSupplierBalanceReportAsync(string? supplierName, DateTime? dateFrom, DateTime? dateTo)
		{
			var query = _context.Suppliers
				   .Select(supplier => new SupplierBalanceReportDTO
				   {
					   SupplierName = supplier.EnglishName,
					   AccountNumber = supplier.Account.Id,
					   TotalPurchase = _context.PurchaseInvoiceHdrs
						   .Where(purchase => purchase.SupplierId == supplier.Id
							   && (dateFrom == null || purchase.InvoiceDate >= dateFrom)
							   && (dateTo == null || purchase.InvoiceDate <= dateTo))
						   .Sum(purchase => purchase.OriginalValue),
					   TotalReturns = _context.PurchaseReturnHdrs
						   .Where(returnHdr => returnHdr.SupplierId == supplier.Id
							   && (dateFrom == null || returnHdr.ReturnDate >= dateFrom)
							   && (dateTo == null || returnHdr.ReturnDate <= dateTo))
						   .Sum(returnHdr => returnHdr.OriginalValue)
				   });

			if (!string.IsNullOrEmpty(supplierName))
			{
				query = query.Where(supplier => supplier.SupplierName.Contains(supplierName));
			}

			var supplierReports = await query.ToListAsync();

			supplierReports.ForEach(item => item.NetPurchases = item.TotalPurchase - item.TotalReturns);

			var totalTotalPurchase = supplierReports.Sum(report => report.TotalPurchase);
			var totalTotalReturns = supplierReports.Sum(report => report.TotalReturns);
			var totalTotalNetPurchases = supplierReports.Sum(report => report.NetPurchases);

			return (supplierReports, totalTotalPurchase, totalTotalReturns, totalTotalNetPurchases);
		}

		public async Task<List<SupplierAccountStatementReportDTO>> GetSupplierAccountStatementReportAsync(string? supplierName, DateTime? fromDate, DateTime? toDate)
		{
			var query = _context.Suppliers.AsQueryable();

			if (!string.IsNullOrEmpty(supplierName))
			{
				query = query.Where(supplier => supplier.EnglishName.Contains(supplierName));
			}

			var report = await query
				.Select(supplier => new SupplierAccountStatementReportDTO
				{
					SupplierName = supplier.EnglishName,
					PurchaseInvoices = _context.PurchaseInvoiceHdrs
						.Where(invoice =>
							invoice.SupplierId == supplier.Id &&
							(!fromDate.HasValue || invoice.InvoiceDate >= fromDate) &&
							(!toDate.HasValue || invoice.InvoiceDate <= toDate))
						.Join(
							_context.JournalDtls,
							invoice => invoice.JournalId,
							journalDtl => journalDtl.Id,
							(invoice, journalDtl) => new InvoiceDTO
							{
								Id = invoice.Id,
								JournalId = journalDtl.JournalId,
								LocalDebit = journalDtl.LocalDebit,
								LocalCredit = journalDtl.LocalCredit,
								Balance = journalDtl.LocalCredit - journalDtl.LocalDebit
							}
						)
						.ToList(),
					ReturnInvoices = _context.PurchaseReturnHdrs
						.Where(returnInvoice =>
							returnInvoice.SupplierId == supplier.Id &&
							(!fromDate.HasValue || returnInvoice.ReturnDate >= fromDate) &&
							(!toDate.HasValue || returnInvoice.ReturnDate <= toDate))
						.Join(
							_context.JournalDtls,
							returnInvoice => returnInvoice.JournalId,
							journalDtl => journalDtl.JournalId,
							(returnInvoice, journalDtl) => new InvoiceDTO
							{
								Id = returnInvoice.Id,
								JournalId = journalDtl.Id,
								LocalDebit = journalDtl.LocalDebit,
								LocalCredit = journalDtl.LocalCredit,
								Balance = journalDtl.LocalCredit - journalDtl.LocalDebit
							}
						)
						.ToList()
				})
				.ToListAsync();

			// Calculate totals 
			foreach (var supplier in report)
			{
				supplier.TotalLocalCredit = supplier.PurchaseInvoices.Sum(invoice => invoice.LocalCredit)
										  + supplier.ReturnInvoices.Sum(invoice => invoice.LocalCredit);
				supplier.TotalLocalDebit = supplier.PurchaseInvoices.Sum(invoice => invoice.LocalDebit)
										 + supplier.ReturnInvoices.Sum(invoice => invoice.LocalDebit);
				supplier.TotalBalance = supplier.TotalLocalCredit - supplier.TotalLocalDebit;
			}

			return report;
		}

		public async Task<List<SupplierPurchaseInvoiceDTO>> GetSupplierPurchaseReport(DateTime? dateFrom, DateTime? dateTo)
		{
			var query = _context.Suppliers
	   .Join(_context.PurchaseInvoiceHdrs,
		   supplier => supplier.Id,
		   purchaseInvoice => purchaseInvoice.SupplierId,
		   (supplier, purchaseInvoice) => new
		   {
			   PurchaseInvoiceHdrId = purchaseInvoice.Id,
			   SupplierName = supplier.EnglishName,
			   OriginalValue = purchaseInvoice.OriginalValue,
			   DiscountValue = purchaseInvoice.DiscountValue,
			   VatValue = purchaseInvoice.VatValue,
			   TotalValue = purchaseInvoice.OriginalValue + purchaseInvoice.VatValue - purchaseInvoice.DiscountValue,
			   InvoiceDate = purchaseInvoice.InvoiceDate
		   });

			if (dateFrom != null && dateTo != null)
			{
				query = query.Where(result =>
					result.InvoiceDate >= dateFrom && result.InvoiceDate <= dateTo
				);
			}

			var supplierPurchaseInvoices = await query
		.GroupBy(result => result.SupplierName)
		.Select(group => new SupplierPurchaseInvoiceDTO
		{
			SupplierName = group.Key,
			PurchaseInvoices = group.Select(result => new PurchaseInvoiceDTO
			{
				Id = result.PurchaseInvoiceHdrId,
				OriginalValue = result.OriginalValue,
				DiscountValue = result.DiscountValue,
				VatValue = result.VatValue,
				TotalValue = result.TotalValue
			}).ToList(),
			TotalTotalValue = group.Sum(result => result.TotalValue),
			TotalVatValue = group.Sum(result => result.VatValue),
			TotalDiscountValue = group.Sum(result => result.DiscountValue),
			TotalOriginalValue = group.Sum(result => result.OriginalValue)
		})
		.ToListAsync();

			return supplierPurchaseInvoices;
		}

		public async Task<List<BasicSuppliersDto>> GetSyppliersReport(string? cityName)
		{
			IQueryable<Supplier> query = _context.Suppliers;

			if (!string.IsNullOrEmpty(cityName))
			{
				// Filter suppliers by city name
				query = query
					.Where(s => s.City.EnglishName == cityName);
			}

			var suppliers = await query
				.Select(s => new BasicSuppliersDto
				{
					Name = s.EnglishName,
					Address = s.EnglishAddress,
					Telephone = s.TelephoneNo,
					Mobile = s.MobileNo
				})
				.ToListAsync();

			if (suppliers == null || suppliers.Count == 0)
			{
				return null;
			}

			return suppliers ;
		}

	}
}
