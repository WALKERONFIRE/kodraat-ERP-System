using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class BankAccountTransaction
    {
        public int Id { get; set; }
        public int BankAccountTransactionId { get; set; }
        public int BankId { get; set; }
        public int BankAccountId { get; set; }
        public int CurrencyId { get; set; }
        public decimal CurrencyRate { get; set; }
        public decimal LocalValue { get; set; }
        public decimal ForeignValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; } = null!;
        public int JournalId { get; set; }
        public long DebitAccountId { get; set; }
        public long CreditAccountId { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public long DebitCostCenterId { get; set; }
        public long CreditCostCenterId { get; set; }
        public int SalesInvoiceId { get; set; }
        public int SalesOrderId { get; set; }
        public int PurchaseInvoiceId { get; set; }
        public int TransactionTypeId { get; set; }
        public int ReceiptTypeId { get; set; }
        public int PaymentTypeId { get; set; }
    }
}
