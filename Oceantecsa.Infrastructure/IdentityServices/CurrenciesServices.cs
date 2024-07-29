using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Persistence.DataContext;
using System.Security.Principal;

namespace OceantecsaAPI.Services
{
	public class CurrenciesServices : ICurrenciesService
	{
		private readonly IDevelopERPContext _context;

		public CurrenciesServices(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Currency>> GetAll()
		{
			return await _context.Currencies.ToListAsync();

		}

		public async Task<Currency> GetById(int id)
		{
			return await _context.Currencies.FirstOrDefaultAsync(m => m.Id == id);
		}

		public async Task<Currency> Add(Currency currency)
		{
			await _context.Currencies.AddAsync(currency);
			_context.SaveChanges();
			return currency;
		}

		public bool CurrencyExists(int id)
		{
			return _context.Currencies.Any(e => e.Id == id);
		}

		public Currency Delete(Currency currency)
		{
			_context.Remove(currency);
			_context.SaveChanges();
			return currency;
		}

		
		public Currency Update(Currency currency)
		{
			_context.Update(currency);
			_context.SaveChanges();
			return currency;
		}
	}
}
