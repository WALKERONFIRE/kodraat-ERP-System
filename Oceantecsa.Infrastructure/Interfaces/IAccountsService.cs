using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Filters;
using Oceantecsa.Infrastructure.Wrappers;

namespace OceantecsaAPI.Services
{
	public interface IAccountsService
	{
		Task<IEnumerable<Account>> GetAll();
		Task<PagedResponse<List<Account>>> GetAllPaged(int pageNumber, float pageSize);
		Task<Account> GetById(long? id);

		Task<Account> Add(Account account);
		Account Update(Account account);
		Account Delete(Account account);

		bool AccountExists(long id);


	}
}
