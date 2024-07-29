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
	public class JournalTypesService : IJournalTypesService
	{
		private readonly IDevelopERPContext _context;

		public JournalTypesService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<JournalType>> GetAll()
		{
			return await _context.JournalTypes.ToListAsync();
		}

		public async Task<JournalType> GetById(int id)
		{
			return await _context.JournalTypes.FirstOrDefaultAsync(m => m.Id == id);
		}

		public async Task<JournalType> Add(JournalType type)
		{
			await _context.JournalTypes.AddAsync(type);
			_context.SaveChanges();
			return type;
		}

		public JournalType Delete(JournalType type)
		{
			_context.Remove(type);
			_context.SaveChanges();
			return type;
		}

		public JournalType Update(JournalType type)
		{
			_context.Update(type);
			_context.SaveChanges();
			return type;
		}

		public bool TypeExists(int id)
		{
			return _context.JournalTypes.Any(e => e.Id == id);
		}


	}
}
