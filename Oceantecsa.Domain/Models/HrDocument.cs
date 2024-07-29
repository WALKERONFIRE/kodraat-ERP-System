using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrDocument
    {
        public HrDocument()
        {
            HrEmpDocuments = new HashSet<HrEmpDocument>();
        }

        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public string FNameA { get; set; } = null!;
        public string FDesc { get; set; } = null!;

        public virtual ICollection<HrEmpDocument> HrEmpDocuments { get; set; }
    }
}
