using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
	public class PurchaseInvoiceDtlsService : IPurchaseInvoiceDtlsService
	{
		private readonly IDevelopERPContext _context;

		public PurchaseInvoiceDtlsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<PurchaseInvoiceDtl>> GetAll()
		{
			return await _context.PurchaseInvoiceDtls.ToListAsync();
		}

		public async Task<PurchaseInvoiceDtl> GetById(long id)
		{
			return await _context.PurchaseInvoiceDtls.FirstOrDefaultAsync(m => m.PurchaseInvoiceHdrId == id);
		}

		public async Task<PurchaseInvoiceDtl> Add(PurchaseInvoiceDtl purchase)
		{
			await _context.PurchaseInvoiceDtls.AddAsync(purchase);
			_context.SaveChanges();
			return purchase;
		}

		public PurchaseInvoiceDtl Delete(PurchaseInvoiceDtl purchase)
		{
			_context.Remove(purchase);
			_context.SaveChanges();
			return purchase;
		}

	
		public bool PurchaseInvoiceDetailExists(long id)
		{
			return _context.PurchaseInvoiceDtls.Any(e => e.PurchaseInvoiceHdrId == id);

		}

		public PurchaseInvoiceDtl Update(PurchaseInvoiceDtl purchase)
		{
			_context.Update(purchase);
			_context.SaveChanges();
			return purchase;
		}
	}
}
