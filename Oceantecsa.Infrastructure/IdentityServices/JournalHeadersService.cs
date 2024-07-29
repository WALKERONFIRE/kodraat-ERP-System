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
	public class JournalHeadersService : IJournalHeadersService
	{
		private readonly IDevelopERPContext _context;

		public JournalHeadersService(IDevelopERPContext context)
		{
			_context = context;
		}
		public async Task<IEnumerable<JournalHdr>> GetAll()
		{
			return await _context.JournalHdrs.ToListAsync();
		}

		public async Task<JournalHdr> GetById(long id)
		{
			return await _context.JournalHdrs.FirstOrDefaultAsync(m => m.Id == id);
		}

		public async Task<JournalHdr> Add(JournalHdr Header)
		{
			await _context.JournalHdrs.AddAsync(Header);
			_context.SaveChanges();
			return Header;
		}

		public JournalHdr Delete(JournalHdr Header)
		{
			_context.Remove(Header);
			_context.SaveChanges();
			return Header;
		}

		public JournalHdr Update(JournalHdr Header)
		{
			_context.Update(Header);
			_context.SaveChanges();
			return Header;
		}

	
		public bool JounralExists(long id)
		{
			return _context.JournalHdrs.Any(e => e.Id == id);
		}
	}
}

