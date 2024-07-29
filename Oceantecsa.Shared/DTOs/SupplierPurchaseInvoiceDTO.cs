using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.DTOs
{
	public class SupplierPurchaseInvoiceDTO
	{
		public string SupplierName { get; set; }
		public List<PurchaseInvoiceDTO> PurchaseInvoices { get; set; }
		public decimal TotalTotalValue { get; set; }
		public decimal TotalVatValue { get; set; }
		public decimal TotalDiscountValue { get; set; }
		public decimal TotalOriginalValue { get; set; }
	}
}
