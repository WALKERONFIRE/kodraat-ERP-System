using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface IPurchaseReturnDtlsService
	{
		Task<IEnumerable<PurchaseReturnDtl>> GetAll();
		Task<PurchaseReturnDtl> GetById(int id);
		
		Task<PurchaseReturnDtl> Add(PurchaseReturnDtl purchaseReturn);
		PurchaseReturnDtl Update(PurchaseReturnDtl purchaseReturn);
		PurchaseReturnDtl Delete(PurchaseReturnDtl purchaseReturn);
	}
}
