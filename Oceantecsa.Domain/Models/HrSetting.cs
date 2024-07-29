using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrSetting
    {
        public int Code { get; set; }
        public string StrConnection { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string CodeField { get; set; } = null!;
        public string EmpId { get; set; } = null!;
        public string LogDate { get; set; } = null!;
        public string LogTime { get; set; } = null!;
        public string LogType { get; set; } = null!;
        public string LogTypeAtt { get; set; } = null!;
        public string LogTypeLeave { get; set; } = null!;
        public string LogTypeIn { get; set; } = null!;
        public string LogTypeOut { get; set; } = null!;
        public string Added { get; set; } = null!;
        /// <summary>
        /// Show if Setting in Table or View
        /// </summary>
        public string ObjType { get; set; } = null!;
        public bool IsSql { get; set; }
    }
}
