using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class PurchaseRequestType
    {
        public PurchaseRequestType()
        {
            PurchaseRequestHdrs = new HashSet<PurchaseRequestHdr>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<PurchaseRequestHdr> PurchaseRequestHdrs { get; set; }
    }
}
