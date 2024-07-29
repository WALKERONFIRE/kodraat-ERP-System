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
	public class SupplierTypesService : ISupplierTypesService
	{
		private readonly IDevelopERPContext _context;

		public SupplierTypesService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<SupplierType>> GetAll()
		{
			return await _context.SupplierTypes.ToListAsync();
		}

		public async Task<SupplierType> GetById(int id)
		{
			return await _context.SupplierTypes.FirstOrDefaultAsync(m => m.Id == id);
		}

		public async Task<SupplierType> Add(SupplierType Type)
		{
			await _context.SupplierTypes.AddAsync(Type);
			_context.SaveChanges();
			return Type;
		}

		public SupplierType Delete(SupplierType Type)
		{
			_context.Remove(Type);
			_context.SaveChanges();
			return Type;
		}

		public SupplierType Update(SupplierType Type)
		{
			_context.Update(Type);
			_context.SaveChanges();
			return Type;
		}

		public bool TypeExists(int id)
		{
			return _context.SupplierTypes.Any(e => e.Id == id);
		}


	}
}
