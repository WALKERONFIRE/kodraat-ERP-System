using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public  interface IPurchaseInvoiceDtlsService
	{

		Task<IEnumerable<PurchaseInvoiceDtl>> GetAll();
		Task<PurchaseInvoiceDtl> GetById(long id);

		Task<PurchaseInvoiceDtl> Add(PurchaseInvoiceDtl purchase);
		PurchaseInvoiceDtl Update(PurchaseInvoiceDtl purchase);
		PurchaseInvoiceDtl Delete(PurchaseInvoiceDtl purchase);

		bool PurchaseInvoiceDetailExists(long id);
	}
}
