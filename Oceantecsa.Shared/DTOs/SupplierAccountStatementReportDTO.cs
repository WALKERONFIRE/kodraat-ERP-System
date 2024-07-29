using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.DTOs
{
	public class SupplierAccountStatementReportDTO
	{
		public string SupplierName { get; set; }
		public List<InvoiceDTO> PurchaseInvoices { get; set; }
		public List<InvoiceDTO> ReturnInvoices { get; set; }
		public decimal TotalLocalCredit { get; set; }
		public decimal TotalLocalDebit { get; set; }
		public decimal TotalBalance { get; set; }
	}
}
