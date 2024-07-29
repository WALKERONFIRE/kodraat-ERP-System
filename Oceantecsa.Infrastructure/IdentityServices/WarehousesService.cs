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
	public class WarehousesService : IWarehousesService
	{
		private readonly IDevelopERPContext _context;

		public WarehousesService(IDevelopERPContext context)
		{
			_context = context;
		}
		public async Task<IEnumerable<Warehouse>> GetAll()
		{
			return await _context.Warehouses.ToListAsync();
		}

		public async Task<Warehouse> GetById(int id)
		{
			return await _context.Warehouses.FirstOrDefaultAsync(m => m.Id == id);
		}
		public async Task<Warehouse> Add(Warehouse Warehouse)
		{
			await _context.Warehouses.AddAsync(Warehouse);
			_context.SaveChanges();
			return Warehouse;
		}

		public Warehouse Delete(Warehouse Warehouse)
		{
			_context.Remove(Warehouse);
			_context.SaveChanges();
			return Warehouse;
		}

		public Warehouse Update(Warehouse Warehouse)
		{
			_context.Update(Warehouse);
			_context.SaveChanges();
			return Warehouse;
		}

		public bool WarehouseExists(int id)
		{
			return _context.Warehouses.Any(e => e.Id == id);
		}
	}
}
