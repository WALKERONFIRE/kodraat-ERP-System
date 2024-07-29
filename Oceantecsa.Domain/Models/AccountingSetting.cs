using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class AccountingSetting
    {
        public int Id { get; set; }
        public int AccountsLevel { get; set; }
        public bool HasCostCenter { get; set; }
        public int CostCentersLevel { get; set; }
        public bool HasAccountActivity { get; set; }
        public int AccountActivitiesLevel { get; set; }
        public bool HasAccountAnalysis { get; set; }
        public int AccountsPayableLevel { get; set; }
        public int AccountsReceivableLevel { get; set; }
        public int HumanResourcesLevel { get; set; }
        public long MainCashBoxAccountId { get; set; }
        public long MainWarehouseAccountId { get; set; }
        public int SystemAdmin { get; set; }
        public int AccountingAdmin { get; set; }
        public int HumanResourcesAdmin { get; set; }
        public int ProductionAdmin { get; set; }
        public int PurchasingAdmin { get; set; }
        public int SalesAdmin { get; set; }
        public int WarehousesAdmin { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
