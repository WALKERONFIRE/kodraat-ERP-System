using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Wrappers;
using OceantecsaAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface ICashboxTransactionDtlsService
	{
		Task<IEnumerable<CashBoxTransactionsDtl>> GetAll();
	
		Task<CashBoxTransactionsDtl> GetById(int? id);

		Task<CashBoxTransactionsDtl> Add(CashBoxTransactionsDtl cashBoxTransactionsDtl);
		CashBoxTransactionsDtl Update(CashBoxTransactionsDtl cashBoxTransactionsDtl);
		CashBoxTransactionsDtl Delete(CashBoxTransactionsDtl cashBoxTransactionsDtl);
		bool CashBoxTransactionsDtlExists(int id);

	}
}
