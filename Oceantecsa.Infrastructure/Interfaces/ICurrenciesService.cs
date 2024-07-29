using Oceantecsa.Domain.Models;

namespace OceantecsaAPI.Services
{
	public interface ICurrenciesService
	{
		Task<IEnumerable<Currency>> GetAll();
		Task<Currency> GetById(int id);

		Task<Currency> Add(Currency currency);
		Currency Update(Currency currency);
		Currency Delete(Currency currency);

		bool CurrencyExists(int id);
	}
}
