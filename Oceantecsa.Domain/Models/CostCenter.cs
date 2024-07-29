using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class CostCenter
    {
        public CostCenter()
        {
            Journals = new HashSet<JournalDtl>();
        }

        public long Id { get; set; }
        public long ParentId { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool HaveSub { get; set; }
        public int CostLevel { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<JournalDtl> Journals { get; set; }
    }
}
