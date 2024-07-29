using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Filters;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Infrastructure.Wrappers;
using Oceantecsa.Persistence.DataContext;
using OceantecsaAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
	public class CashboxTransactionHdrsService : ICashboxTransactionHdrsService
	{
		private readonly IDevelopERPContext _context;


		public CashboxTransactionHdrsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<CashBoxTransactionsHdr>> GetAll()
		{
			return await _context.CashBoxTransactionsHdrs.ToListAsync();
		}

		public async Task<PagedResponse<List<CashBoxTransactionsHdr>>> GetAllPaged(int pageNumber, float pageSize)
		{
			var validFilter = new PaginationFilter(pageNumber, pageSize);
			var PagedData = await _context.CashBoxTransactionsHdrs.Skip(((validFilter.PageNumber - 1) * (int)validFilter.PageSize))
													.Take((int)validFilter.PageSize)
													.ToListAsync();
			var totalRecords = await _context.CashBoxTransactionsHdrs.CountAsync();
			var pageCount = Math.Ceiling(_context.CashBoxTransactionsHdrs.Count() / pageSize);
			var paginatedResponse = new PagedResponse<List<CashBoxTransactionsHdr>>(PagedData, validFilter.PageNumber, validFilter.PageSize, totalRecords, pageCount);
			return paginatedResponse;
		}

		public async Task<CashBoxTransactionsHdr> GetById(long? id)
		{
			return await _context.CashBoxTransactionsHdrs.FirstOrDefaultAsync(m => m.Id == id);
		}

		public async Task<CashBoxTransactionsHdr> Add(CashBoxTransactionsHdr cashBoxTransactionsHdr)
		{
			await _context.CashBoxTransactionsHdrs.AddAsync(cashBoxTransactionsHdr);
			_context.SaveChanges();
			return cashBoxTransactionsHdr;
		}

		public CashBoxTransactionsHdr Delete(CashBoxTransactionsHdr cashBoxTransactionsHdr)
		{
			_context.Remove(cashBoxTransactionsHdr);
			_context.SaveChanges();
			return cashBoxTransactionsHdr;
		}


		public CashBoxTransactionsHdr Update(CashBoxTransactionsHdr cashBoxTransactionsHdr)
		{
			_context.Update(cashBoxTransactionsHdr);
			_context.SaveChanges();
			return cashBoxTransactionsHdr;
		}

		public bool CashboxTransactionHdrExists(long id)
		{
			return _context.CashBoxTransactionsHdrs.Any(e => e.Id == id);
		}



	}
}
