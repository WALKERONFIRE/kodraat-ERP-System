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
	public class PaymentByEmployeeReportsService : IPaymentByEmployeeReportsService
	{
		private readonly IDevelopERPContext _context;

		public PaymentByEmployeeReportsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<PaymentReport> GetPaymentReportByEmployeeReports(DateTime? dateFrom, DateTime? dateTo)
		{
			Customer customer = new Customer();
			Employee employee = new Employee();
			PaymentType paymentType = new PaymentType();
			try
			{
				if (dateFrom.HasValue && dateTo.HasValue && dateFrom > dateTo)
				{
					return null;
				}
				var query = _context.PurchaseInvoiceDtls.AsQueryable();
				if (dateFrom.HasValue)
				{
					query = query.Where(x => x.PurchaseInvoiceHdr.CreatedDate >= dateFrom);
				}
				if (dateTo.HasValue)
				{
					query = query.Where(x => x.PurchaseInvoiceHdr.CreatedDate <= dateTo);
				}
				var paymentEmployeeReports = await query.Select(x=> new PaymentReportDtl
				{ 
				
				EmployeeArabicName = employee.ArabicName,
				EmployeeEnglishName= employee.EnglishName,
				PurchaseInvoiceId = x.PurchaseInvoiceHdrId,
				DateCreated= x.PurchaseInvoiceHdr.CreatedDate,
				PaymentTypeId= paymentType.Id,
				CustomerArabicName= customer.ArabicName,
				CustomerEnglishName= customer.EnglishName,
				Price= (double)x.Price,
			
				}				
				).ToListAsync();

				var totalPrice = paymentEmployeeReports.Sum(x => x.Price);
				return new PaymentReport
				{
					TotalPrice = totalPrice,
					PaymentReportDtl= paymentEmployeeReports,

				};

			}
			catch(Exception ex )
			{
				return null; 
			}
		}
	}
}
