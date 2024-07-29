using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrInstPayDtl
    {
        public int? FPayCode { get; set; }
        public int? FPayInvoice { get; set; }
        public DateTime? PayInvDate { get; set; }
        public decimal? FPayAmount { get; set; }
        public bool? FDeleted { get; set; }
        public DateTime? FRepDate { get; set; }
        public int? FBranchId { get; set; }
        public bool? FReplicated { get; set; }
    }
}
