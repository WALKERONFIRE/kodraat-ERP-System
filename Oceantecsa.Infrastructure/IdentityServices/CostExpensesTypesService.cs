using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Persistence.DataContext;

namespace OceantecsaAPI.Services
{
	public class CostExpensesTypesService : ICostExpensesTypesService
	{
		private readonly IDevelopERPContext _context;

		public CostExpensesTypesService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<CostExpensesType>> GetAll()
		{
			return await _context.CostExpensesTypes.ToListAsync();
		}

		public async Task<CostExpensesType> GetById(int? id)
		{
			return await _context.CostExpensesTypes.FirstOrDefaultAsync(m => m.Id == id);
		}

		public async Task<CostExpensesType> Add(CostExpensesType Type)
		{
			await _context.CostExpensesTypes.AddAsync(Type);
			_context.SaveChanges();
			return Type;
		}

		public bool CostExpensesTypeExists(int id)
		{
			return _context.CostExpensesTypes.Any(e => e.Id == id);
		}

		public CostExpensesType Delete(CostExpensesType Type)
		{
			_context.Remove(Type);
			_context.SaveChanges();
			return Type;
		}

		

		public CostExpensesType Update(CostExpensesType Type)
		{
			_context.Update(Type);
			_context.SaveChanges();
			return Type;
		}
	}
}
