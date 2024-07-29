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
	public interface ICashboxTransactionHdrsService
	{
		Task<IEnumerable<CashBoxTransactionsHdr>> GetAll();
		Task<PagedResponse<List<CashBoxTransactionsHdr>>> GetAllPaged(int pageNumber, float pageSize);
		Task<CashBoxTransactionsHdr> GetById(long? id);

		Task<CashBoxTransactionsHdr> Add(CashBoxTransactionsHdr cashBoxTransactionsHdr);
		CashBoxTransactionsHdr Update(CashBoxTransactionsHdr cashBoxTransactionsHdr);
		CashBoxTransactionsHdr Delete(CashBoxTransactionsHdr cashBoxTransactionsHdr);

		bool CashboxTransactionHdrExists(long id);
	}
}
