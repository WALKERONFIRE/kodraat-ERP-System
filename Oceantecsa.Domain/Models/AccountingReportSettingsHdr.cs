using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class AccountingReportSettingsHdr
    {
        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int AccountLevel { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
