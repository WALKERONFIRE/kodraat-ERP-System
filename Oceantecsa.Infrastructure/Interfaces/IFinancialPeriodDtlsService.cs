using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface IFinancialPeriodDtlsService
	{
		Task<IEnumerable<FinancialPeriodDtl>> GetAll();
		Task<FinancialPeriodDtl> GetById(int id);

		Task<FinancialPeriodDtl> Add(FinancialPeriodDtl Period);
		FinancialPeriodDtl Update(FinancialPeriodDtl Period);
		FinancialPeriodDtl Delete(FinancialPeriodDtl Period);

		bool FinancialPeriodDetailExists(int id);
	}
}
