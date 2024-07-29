using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrempGroupHist
    {
        public int GroupId { get; set; }
        public int EmpId { get; set; }
        /// <summary>
        /// 0 trans from 1 trans To
        /// </summary>
        public int FType { get; set; }
        public DateTime FDate { get; set; }
    }
}
