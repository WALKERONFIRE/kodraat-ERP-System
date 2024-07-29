using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class AccountingReportSettingsDtl
    {
        public int AccountingReportSettingsHdrId { get; set; }
        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int AccountTypeId { get; set; }
        public string AccountIds { get; set; } = null!;
        public string AccountEnglishNames { get; set; } = null!;
        public string AccountArabicNames { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
