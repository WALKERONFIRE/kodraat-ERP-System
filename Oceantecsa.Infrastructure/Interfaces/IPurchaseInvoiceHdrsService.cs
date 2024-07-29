using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface IPurchaseInvoiceHdrsService
	{
		Task<IEnumerable<PurchaseInvoiceHdr>> GetAll();
		Task<PurchaseInvoiceHdr> GetById(long id);
		Task<IEnumerable<PurchaseInvoiceHdr>> GetByBranchId(int id);
		Task<PurchaseInvoiceHdr> GetByPruchaseInvoiceId(long id);
		Task<PurchaseInvoiceHdr> Add(PurchaseInvoiceHdr purchase);
		PurchaseInvoiceHdr Update(PurchaseInvoiceHdr purchase);
		PurchaseInvoiceHdr Delete(PurchaseInvoiceHdr purchase);

		bool PurchaseInvoiceHeaderExists(long id);
	}
}
