using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Persistence.DataContext;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace OceantecsaAPI.Services
{
	public class AccountActivitiesServices : IAccountActivitiesServices
	{
		private readonly IDevelopERPContext _context;

		public AccountActivitiesServices(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<AccountActivity>> GetAll()
		{
			return await _context.AccountActivities.ToListAsync();
		}

		public async Task<AccountActivity> GetById(long? id)
		{
			return await _context.AccountActivities.FirstOrDefaultAsync(m => m.Id == id);
		}
		public async Task<AccountActivity> Add(AccountActivity activity)
		{
			await _context.AccountActivities.AddAsync(activity);
			_context.SaveChanges();
			return activity;
		}

		public AccountActivity Delete(AccountActivity activity)
		{
			_context.Remove(activity);
			_context.SaveChanges();
			return activity;
		}



		public AccountActivity Update(AccountActivity activity)
		{
			_context.Update(activity);
			_context.SaveChanges();
			return activity;
		}

		public bool AccountExists(long id)
		{
			throw new NotImplementedException();
		}

	}
}
