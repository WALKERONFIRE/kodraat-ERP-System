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
	public class PurchaseReturnHdrsService : IPurchaseReturnHdrsService
	{
		private readonly IDevelopERPContext _context;

		public PurchaseReturnHdrsService(IDevelopERPContext context)
		{
			_context = context;
		}

		
		public async Task<IEnumerable<PurchaseReturnHdr>> GetAll()
		{
			return await _context.PurchaseReturnHdrs.Include(x=>x.PurchaseReturnDtls).ToListAsync();
		}
		public async Task<PurchaseReturnHdr> GetById(long id)
		{
			return await _context.PurchaseReturnHdrs.FirstOrDefaultAsync(m => m.Id == id);
		}

		public async Task<PurchaseReturnHdr> GetByPruchaseInvoice(long id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<PurchaseReturnHdr>> GetByBranchId(int branchId)
		{
			throw new NotImplementedException();
		}
		public async Task<PurchaseReturnHdr> Add(PurchaseReturnHdr purchaseReturn)
		{
			await _context.PurchaseReturnHdrs.AddAsync(purchaseReturn);
			_context.SaveChanges();
			return purchaseReturn;
		}

		public PurchaseReturnHdr Delete(PurchaseReturnHdr purchaseReturn)
		{
			_context.Remove(purchaseReturn);
			_context.SaveChanges();
			return purchaseReturn;
		}

		


		public PurchaseReturnHdr Update(PurchaseReturnHdr purchaseReturn)
		{
			_context.Update(purchaseReturn);
			_context.SaveChanges();
			return purchaseReturn;
		}

		
	}
}
