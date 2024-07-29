using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
	public class FinancialPeriodDtlsService : IFinancialPeriodDtlsService
	{
		private readonly IDevelopERPContext _context;

		public FinancialPeriodDtlsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public Task<FinancialPeriodDtl> Add(FinancialPeriodDtl Period)
		{
			throw new NotImplementedException();
		}

		public FinancialPeriodDtl Delete(FinancialPeriodDtl Period)
		{
			throw new NotImplementedException();
		}

		public bool FinancialPeriodDetailExists(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<FinancialPeriodDtl>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<FinancialPeriodDtl> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public FinancialPeriodDtl Update(FinancialPeriodDtl Period)
		{
			throw new NotImplementedException();
		}
	}
}
