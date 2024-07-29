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
	public class WarehouseTypesService : IWarehouseTypesService
	{
		private readonly IDevelopERPContext _context;

		public WarehouseTypesService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<WarehouseType>> GetAll()
		{
			return await _context.WarehouseTypes.ToListAsync();

		}

		public async Task<WarehouseType> GetById(int id)
		{
			return await _context.WarehouseTypes.FirstOrDefaultAsync(m => m.Id == id);
		}

		public async Task<WarehouseType> Add(WarehouseType Type)
		{
			await _context.WarehouseTypes.AddAsync(Type);
			_context.SaveChanges();
			return Type;
		}

		public WarehouseType Delete(WarehouseType Type)
		{
			_context.Remove(Type);
			_context.SaveChanges();
			return Type;
		}


		public WarehouseType Update(WarehouseType Type)
		{
			_context.Update(Type);
			_context.SaveChanges();
			return Type;
		}

		public bool TypeExists(int id)
		{
			return _context.WarehouseTypes.Any(e => e.Id == id);
		}
	}
}
