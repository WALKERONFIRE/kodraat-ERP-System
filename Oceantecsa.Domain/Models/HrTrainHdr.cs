using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrTrainHdr
    {
        public HrTrainHdr()
        {
            HrTrainDtls = new HashSet<HrTrainDtl>();
        }

        public int TrainHdrId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string TrainType { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<HrTrainDtl> HrTrainDtls { get; set; }
    }
}
