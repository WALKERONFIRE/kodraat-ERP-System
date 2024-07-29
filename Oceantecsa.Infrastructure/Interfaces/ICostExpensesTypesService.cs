using Oceantecsa.Domain.Models;

namespace OceantecsaAPI.Services
{
	public interface ICostExpensesTypesService
	{
		Task<IEnumerable<CostExpensesType>> GetAll();
		Task<CostExpensesType> GetById(int? id);

		Task<CostExpensesType> Add(CostExpensesType Type);
		CostExpensesType Update(CostExpensesType Type);
		CostExpensesType Delete(CostExpensesType Type);

		bool CostExpensesTypeExists(int id);
	}
}
