using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrInstPayHdr
    {
        public int? FPayCode { get; set; }
        public DateTime? FPayDate { get; set; }
        public int? EmpId { get; set; }
        public string? FPayDesc { get; set; }
        public string? FPerson { get; set; }
        public bool? FPayType { get; set; }
        public string? FNotes { get; set; }
        public decimal? FPayValue { get; set; }
        public bool? FDeleted { get; set; }
        public DateTime? FRepDate { get; set; }
        public int? FBranchId { get; set; }
        public bool? FReplicated { get; set; }
        public bool FPosted { get; set; }
        public string FReceiptNo { get; set; } = null!;
        public int PrePaidId { get; set; }
    }
}
