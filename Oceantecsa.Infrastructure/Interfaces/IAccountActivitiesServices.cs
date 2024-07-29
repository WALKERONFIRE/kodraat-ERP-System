using Oceantecsa.Domain.Models;
namespace OceantecsaAPI.Services
{
	public interface IAccountActivitiesServices
	{
		Task<IEnumerable<AccountActivity>> GetAll();

		Task<AccountActivity> GetById(long? id);

		Task<AccountActivity> Add(AccountActivity activity);

		AccountActivity Update(AccountActivity activity);

		AccountActivity Delete(AccountActivity activity);

		bool AccountExists(long id);
	}
}
