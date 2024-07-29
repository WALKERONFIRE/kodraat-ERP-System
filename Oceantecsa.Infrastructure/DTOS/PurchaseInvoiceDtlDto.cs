using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
	public class PurchaseInvoiceDtlDto
	{
	
		public long PurchaseInvoiceHdrId { get; set; }
		public long ProductId { get; set; }
		public int UnitId { get; set; }
		public decimal Quantity { get; set; }
		public decimal Price { get; set; }
		public decimal DiscountPercent { get; set; }
		public decimal DiscountValue { get; set; }
		public decimal NetValue { get; set; }
		public decimal VatPercent { get; set; }
		public decimal VatValue { get; set; }
		public decimal TotalValue { get; set; }
		public string ProductDescription { get; set; } = null!;
		public decimal ReturnedQuantity { get; set; }
		public bool IsDeleted { get; set; }
	}
}
