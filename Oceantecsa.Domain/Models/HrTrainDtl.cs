using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrTrainDtl
    {
        public int TrainDtlId { get; set; }
        public int TrainHdrId { get; set; }
        public int EmpId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Target { get; set; } = null!;
        public string Result { get; set; } = null!;
        public string Notes { get; set; } = null!;

        public virtual HrTrainHdr TrainHdr { get; set; } = null!;
    }
}
