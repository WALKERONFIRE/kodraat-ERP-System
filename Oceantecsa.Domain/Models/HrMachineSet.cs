using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrMachineSet
    {
        public int Code { get; set; }
        public string MachineName { get; set; } = null!;
        public int DevNo { get; set; }
        public string ComType { get; set; } = null!;
        public string BaudRate { get; set; } = null!;
        public string PortName { get; set; } = null!;
        public string IpAddress { get; set; } = null!;
        public string ComKey { get; set; } = null!;
        public string StateAtt { get; set; } = null!;
        public string StateLeave { get; set; } = null!;
        public string StateIn { get; set; } = null!;
        public string StateOut { get; set; } = null!;
        public string StateIn1 { get; set; } = null!;
        public string StateOut1 { get; set; } = null!;
        public string StateIn2 { get; set; } = null!;
        public string StateOut2 { get; set; } = null!;
        public string StateIn3 { get; set; } = null!;
        public string StateOut3 { get; set; } = null!;
        public string StateIn4 { get; set; } = null!;
        public string StateOut4 { get; set; } = null!;
    }
}
