using Oceantecsa.Domain.Models;

namespace OceantecsaAPI.Services
{
	public interface IFinancialPeriodHdrsService
	{
		Task<IEnumerable<FinancialPeriodHdr>> GetAll();
		Task<FinancialPeriodHdr> GetById(int id);

		Task<FinancialPeriodHdr> Add(FinancialPeriodHdr Period);
		FinancialPeriodHdr Update(FinancialPeriodHdr Period);
		FinancialPeriodHdr Delete(FinancialPeriodHdr Period);

		bool FinancialPeriodHeaderExists(int id);
	}
}

