using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class CashBoxTransactionsHdr
    {
        public CashBoxTransactionsHdr()
        {
            CashBoxTransactionsDtls = new HashSet<CashBoxTransactionsDtl>();
        }

        public long Id { get; set; }
        public int BranchId { get; set; }
        public int CashBoxId { get; set; }
        public int CurrencyId { get; set; }
        public decimal CurrencyRate { get; set; }
        public decimal LocalValue { get; set; }
        public decimal ForeignValue { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; } = null!;
        public int TransactionTypeId { get; set; }
        public int ReceiptTypeId { get; set; }
        public int PaymentTypeId { get; set; }
        public int JournalId { get; set; }
        public int CustomerId { get; set; }
        public int SalesInvoiceId { get; set; }
        public int SalesOrderId { get; set; }
        public int SupplierId { get; set; }
        public int PurchaseInvoiceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUser { get; set; }
        public DateTime PostedDate { get; set; }
        public int PostedUser { get; set; }
        public bool Posted { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int BankAccountId { get; set; }

        public virtual ICollection<CashBoxTransactionsDtl> CashBoxTransactionsDtls { get; set; }
    }
}
