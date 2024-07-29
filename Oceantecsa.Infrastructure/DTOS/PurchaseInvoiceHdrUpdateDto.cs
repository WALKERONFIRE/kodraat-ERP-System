using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
	public class PurchaseInvoiceHdrUpdateDto
	{
		public long Id { get; set; }
		public long PurchaseInvoiceId { get; set; }
		public int TypeId { get; set; }
		public int BranchId { get; set; }
		public int WarehouseId { get; set; }
		public int SupplierId { get; set; }
		public string SupplierInvoiceId { get; set; } = null!;
		public long PurchaseOrderId { get; set; }
		public int CashBoxId { get; set; }
		public int BankAccountId { get; set; }
		public DateTime InvoiceDate { get; set; }
		public string InvoiceDescription { get; set; } = null!;
		public decimal OriginalValue { get; set; }
		public decimal DiscountPercent { get; set; }
		public decimal DiscountValue { get; set; }
		public decimal NetValue { get; set; }
		public decimal VatPercent { get; set; }
		public decimal VatValue { get; set; }
		public decimal InvoiceValue { get; set; }
		public decimal PaidValue { get; set; }
		public long JournalId { get; set; }
		public DateTime CreatedDate { get; set; }
		public int CreatedUser { get; set; }
		public DateTime ModifiedDate { get; set; }
		public int ModifiedUser { get; set; }
		public DateTime PostedDate { get; set; }
		public int PostedUser { get; set; }
		
		public bool IsDeleted { get; set; }
		public int LocationId { get; set; }
		public virtual ICollection<PurchaseInvoiceDtlDto> PurchaseInvoiceDtlDto { get; set; }

	}
}
