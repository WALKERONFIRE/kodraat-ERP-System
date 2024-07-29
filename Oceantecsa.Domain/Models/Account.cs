using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class Account
    {
        public Account()
        {
            BankAccounts = new HashSet<BankAccount>();
            CashBoxes = new HashSet<CashBox>();
            Customers = new HashSet<Customer>();
            Suppliers = new HashSet<Supplier>();
            Warehouses = new HashSet<Warehouse>();
        }

        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string? EnglishName { get; set; }
        public string? ArabicName { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? HaveSub { get; set; }
        public int? AccountLevel { get; set; }
        public int? AccountTypeId { get; set; }
        public int? AccountCloseTypeId { get; set; }
        public int AccountGroupId { get; set; }
        public int CashFlowTypeId { get; set; }
        public int CostExpensesTypeId { get; set; }
        public int FinancialStatmentTypeId { get; set; }
        public int GeneralExpenseTypeId { get; set; }
        public int ManufacturingCostTypeId { get; set; }
        public int DirectCashFlowTypeId { get; set; }
        public int CostCategoryTypeId { get; set; }
        public bool HaveAccountActivity { get; set; }
        public long AccountActivityId { get; set; }
        public bool HaveCostCenter { get; set; }
        public long CostCenterId { get; set; }
        public bool HaveAccountAnalysis { get; set; }
        public int AccountAnalysisTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<BankAccount> BankAccounts { get; set; }
        public virtual ICollection<CashBox> CashBoxes { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
