using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.DTOs
{
	public class PurchaseInvoiceDTO
	{
		public long Id { get; set; }
		public decimal OriginalValue { get; set; }
		public decimal DiscountValue { get; set; }
		public decimal VatValue { get; set; }
		public decimal TotalValue { get; set; }
	}
}
