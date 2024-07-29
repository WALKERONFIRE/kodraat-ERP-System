using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrStopStartEmp
    {
        public int EmpId { get; set; }
        public DateTime FDate { get; set; }
        public string FReason { get; set; } = null!;
        public int TypeId { get; set; }
        /// <summary>
        /// 0 - Stop      1 - Start
        /// </summary>
        public short State { get; set; }
        /// <summary>
        /// 0 - Not First     1 - First State
        /// </summary>
        public short FirstState { get; set; }
    }
}
