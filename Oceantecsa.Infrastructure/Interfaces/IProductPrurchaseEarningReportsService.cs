using Oceantecsa.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface IProductPrurchaseEarningReportsService
	{
		public Task<EarningPeriod> GetProductEarningReports(DateTime? dateFrom, DateTime? dateTo);

	}
}
