using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface IPurchaseReturnHdrsService
	{
		Task<IEnumerable<PurchaseReturnHdr>> GetAll();
		Task<PurchaseReturnHdr> GetById(long id);
		Task<PurchaseReturnHdr> GetByPruchaseInvoice(long id);
		Task<IEnumerable<PurchaseReturnHdr>> GetByBranchId(int branchId);
		Task<PurchaseReturnHdr> Add(PurchaseReturnHdr purchaseReturn);
		PurchaseReturnHdr Update(PurchaseReturnHdr purchaseReturn);
		PurchaseReturnHdr Delete(PurchaseReturnHdr purchaseReturn);


	}
}
