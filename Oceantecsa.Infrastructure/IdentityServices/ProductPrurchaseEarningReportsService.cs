using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
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
	public class ProductPrurchaseEarningReportsService : IProductPrurchaseEarningReportsService
	{
		private readonly IDevelopERPContext _context;

		public ProductPrurchaseEarningReportsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<EarningPeriod> GetProductEarningReports(DateTime? dateFrom, DateTime? dateTo)
		{
			Customer customer = new Customer();

			try
			{
				if (dateFrom.HasValue && dateTo.HasValue && dateFrom > dateTo)
				{
					return null;
				}
				var query = _context.SalesInvoiceDtls.AsQueryable();
				if (dateFrom.HasValue)
				{
					query = query.Where(x => x.SalesInvoiceHdr.CreatedDate >= dateFrom);
				}
				if (dateTo.HasValue)
				{
					query = query.Where(x => x.SalesInvoiceHdr.CreatedDate <= dateTo);
				}
				var earningreports = await query.Select(x => new EarningPeriodDtl
				{
					CustomerArabicName = customer.ArabicName,
					CustomerEnglishName = customer.EnglishName,
					SalesInvoiceId = x.SalesInvoiceHdrId,
					ProductEnglishName=x.Product.EnglishName,
					ProductArabicName=x.Product.ArabicName,
					Quantity = x.Quantity,
					DiscountValue = x.DiscountValue,
					OriginalValue=x.SalesInvoiceHdr.OriginalValue,
					NetValue=x.NetValue,
					PaidValue = x.SalesInvoiceHdr.PaidValue,
					Price= x.SalesInvoiceHdr.PaidValue * x.Quantity ,
					Earning = x.NetValue - (x.SalesInvoiceHdr.PaidValue * x.Quantity)
				}).ToListAsync();

				var totalEarnings = earningreports.Sum(x => x.Earning);
				return new EarningPeriod
				{
					TotalPrice = totalEarnings,
					EarningPeriodDtl = earningreports,
				};
			}
			catch (Exception ex) 
			{
				return null;
			}
		}
	}
}
