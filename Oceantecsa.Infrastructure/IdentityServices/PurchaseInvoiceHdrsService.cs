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
	public class PurchaseInvoiceHdrsService : IPurchaseInvoiceHdrsService
	{
		private readonly IDevelopERPContext _context;

		public PurchaseInvoiceHdrsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<PurchaseInvoiceHdr>> GetAll()
		{
			return await _context.PurchaseInvoiceHdrs.Include(x=>x.PurchaseInvoiceDtls).ToListAsync();

		}

		public async Task<PurchaseInvoiceHdr> GetById(long id)
		{
			return await _context.PurchaseInvoiceHdrs.FirstOrDefaultAsync(m => m.Id == id);
		}

		public async Task<IEnumerable<PurchaseInvoiceHdr>> GetByBranchId(int id)
		{
			return await _context.PurchaseInvoiceHdrs.Where(x => x.BranchId == id).ToListAsync();
		}
		public async Task<PurchaseInvoiceHdr> GetByPruchaseInvoiceId(long id)
		{
			return await _context.PurchaseInvoiceHdrs.FirstOrDefaultAsync(m => m.PurchaseInvoiceId == id);
		}

		public async Task<PurchaseInvoiceHdr> Add(PurchaseInvoiceHdr purchase)
		{
			await _context.PurchaseInvoiceHdrs.AddAsync(purchase);
			_context.SaveChanges();
			return purchase;
		}

		public PurchaseInvoiceHdr Delete(PurchaseInvoiceHdr purchase)
		{
			_context.Remove(purchase);
			_context.SaveChanges();
			return purchase;
		}
		public PurchaseInvoiceHdr Update(PurchaseInvoiceHdr purchase)
		{
			_context.Update(purchase);
			_context.SaveChanges();
			return purchase;
		}


		public bool PurchaseInvoiceHeaderExists(long id)
		{
			return _context.PurchaseInvoiceHdrs.Any(e => e.Id == id);
		}

		
	}
}
