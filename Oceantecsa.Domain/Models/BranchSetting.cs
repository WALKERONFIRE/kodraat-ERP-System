using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class BranchSetting
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public long CostCenterId { get; set; }
        public int CashBoxId { get; set; }
        public long CashBoxAccountId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
