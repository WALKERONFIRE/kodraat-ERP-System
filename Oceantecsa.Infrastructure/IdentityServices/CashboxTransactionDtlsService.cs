using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using OceantecsaAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
	public class CashboxTransactionDtlsService : ICashboxTransactionDtlsService
	{
		private readonly IDevelopERPContext _context;

		public CashboxTransactionDtlsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<CashBoxTransactionsDtl>> GetAll()
		{
			return await _context.CashBoxTransactionsDtls.ToListAsync();
		}

		public async Task<CashBoxTransactionsDtl> GetById(int? id)
		{
			return await _context.CashBoxTransactionsDtls.FirstOrDefaultAsync(m => m.Id == id);
		}

		public async Task<CashBoxTransactionsDtl> Add(CashBoxTransactionsDtl cashBoxTransactionsDtl)
		{
			await _context.CashBoxTransactionsDtls.AddAsync(cashBoxTransactionsDtl);
			_context.SaveChanges();
			return cashBoxTransactionsDtl;
		}

		public CashBoxTransactionsDtl Delete(CashBoxTransactionsDtl cashBoxTransactionsDtl)
		{
			_context.Remove(cashBoxTransactionsDtl);
			_context.SaveChanges();
			return cashBoxTransactionsDtl;
		}
	
		public CashBoxTransactionsDtl Update(CashBoxTransactionsDtl cashBoxTransactionsDtl)
		{
			_context.Update(cashBoxTransactionsDtl);
			_context.SaveChanges();
			return cashBoxTransactionsDtl;
		}



		public bool CashBoxTransactionsDtlExists(int id)
		{
			return _context.CashBoxTransactionsDtls.Any(e => e.Id == id);
		}
	}
}
