using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class PurchaseReturnHdr
    {
        public PurchaseReturnHdr()
        {
            PurchaseReturnDtls = new HashSet<PurchaseReturnDtl>();
        }

        public long Id { get; set; }
        public long PurchaseReturnId { get; set; }
        public int TypeId { get; set; }
        public int BranchId { get; set; }
        public int WarehouseId { get; set; }
        public int SupplierId { get; set; }
        public int CashBoxId { get; set; }
        public int BankAccountId { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnDescription { get; set; } = null!;
        public decimal OriginalValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal NetValue { get; set; }
        public decimal VatPercent { get; set; }
        public decimal VatValue { get; set; }
        public decimal ReturnValue { get; set; }
        public long JournalId { get; set; }
        public long PurchaseInvoiceHdrId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUser { get; set; }
        public DateTime PostedDate { get; set; }
        public int PostedUser { get; set; }
        public bool Posted { get; set; }
        public bool IsDeleted { get; set; }
        public int LocationId { get; set; }

        public virtual ICollection<PurchaseReturnDtl> PurchaseReturnDtls { get; set; }
    }
}
