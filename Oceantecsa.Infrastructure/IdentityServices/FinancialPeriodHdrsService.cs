using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Persistence.DataContext;
using System.Security.Principal;

namespace OceantecsaAPI.Services
{
	public class FinancialPeriodHdrsService : IFinancialPeriodHdrsService
	{
		private readonly IDevelopERPContext _context;

		public FinancialPeriodHdrsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<FinancialPeriodHdr>> GetAll()
		{
			return await _context.FinancialPeriodHdrs.ToListAsync();
		}

		public async Task<FinancialPeriodHdr> GetById(int id)
		{
			return await _context.FinancialPeriodHdrs.FirstOrDefaultAsync(m => m.Id == id);
		}
		public async Task<FinancialPeriodHdr> Add(FinancialPeriodHdr Period)
		{
			await _context.FinancialPeriodHdrs.AddAsync(Period);
			_context.SaveChanges();
			return Period;
		}

		public FinancialPeriodHdr Delete(FinancialPeriodHdr Period)
		{
			_context.Remove(Period);
			_context.SaveChanges();
			return Period;
		}

		public FinancialPeriodHdr Update(FinancialPeriodHdr Period)
		{
			_context.Update(Period);
			_context.SaveChanges();
			return Period;
		}
		public bool FinancialPeriodHeaderExists(int id)
		{
			return _context.FinancialPeriodHdrs.Any(e => e.Id == id);
		}

	}
}
