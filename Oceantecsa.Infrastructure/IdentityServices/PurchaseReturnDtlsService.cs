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
	public class PurchaseReturnDtlsService : IPurchaseReturnDtlsService
	{
		private readonly IDevelopERPContext _context;

		public PurchaseReturnDtlsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<PurchaseReturnDtl>> GetAll()
		{
			return await _context.PurchaseReturnDtls.ToListAsync();
		}

		public async Task<PurchaseReturnDtl> GetById(int id)
		{
			return await _context.PurchaseReturnDtls.FirstOrDefaultAsync(m => m.PurchaseReturnHdrId == id);
		}
		public async Task<PurchaseReturnDtl> Add(PurchaseReturnDtl purchaseReturn)
		{
			await _context.PurchaseReturnDtls.AddAsync(purchaseReturn);
			_context.SaveChanges();
			return purchaseReturn;
		}

		public PurchaseReturnDtl Delete(PurchaseReturnDtl purchaseReturn)
		{
			_context.Remove(purchaseReturn);
			_context.SaveChanges();
			return purchaseReturn;
		}

		

		public PurchaseReturnDtl Update(PurchaseReturnDtl purchaseReturn)
		{
			_context.Update(purchaseReturn);
			_context.SaveChanges();
			return purchaseReturn;
		}
	}
}
