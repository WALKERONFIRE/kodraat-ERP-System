using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Filters;
using Oceantecsa.Infrastructure.Wrappers;
using Oceantecsa.Persistence.DataContext;
using OceantecsaAPI.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadbusiness.web.Services
{
	public class AccountsService : IAccountsService
	{
		private readonly IDevelopERPContext _context;

		public AccountsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Account>> GetAll()
		{
			return await _context.Accounts.ToListAsync();
		}
		
		public async Task<Account> GetById(long? id)
		{
			return await _context.Accounts.FirstOrDefaultAsync(m => m.Id == id);

		}

		public  async Task<Account> Add(Account account)
		{
			await _context.Accounts.AddAsync(account);
			_context.SaveChanges();
			return account;
		}

		public Account Delete(Account account)
		{
			_context.Remove(account);
			_context.SaveChanges();
			return account;
		}

		

		public Account Update(Account account)
		{
			_context.Update(account);
			_context.SaveChanges();
			return account;
		}

		public bool AccountExists(long id)
		{
			return _context.Accounts.Any(e => e.Id == id);

		}

		public async Task<PagedResponse<List<Account>>> GetAllPaged(int pageNumber, float pageSize)
		{
			var validFilter = new PaginationFilter(pageNumber, pageSize);
			var PagedData = await _context.Accounts.Skip(((validFilter.PageNumber - 1) * (int)validFilter.PageSize))
													.Take((int)validFilter.PageSize)
													.ToListAsync();
			var totalRecords = await _context.Accounts.CountAsync();
			var pageCount = Math.Ceiling(_context.Accounts.Count() / pageSize);
			var paginatedResponse = new PagedResponse<List<Account>>(PagedData, validFilter.PageNumber, validFilter.PageSize, totalRecords, pageCount);
			return paginatedResponse;
		}
	}
}
