using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class HrExchangeTicket
    {
        public int FId { get; set; }
        public int EmpCode { get; set; }
        public float TicketCount { get; set; }
        public DateTime FDate { get; set; }
        public string Destination { get; set; } = null!;
        public float TicketValue { get; set; }
        public bool FPosted { get; set; }
        /// <summary>
        /// replace ticket with money
        /// </summary>
        public bool TicketAllowence { get; set; }
        public int SalryItem { get; set; }

        public virtual TblEmployee EmpCodeNavigation { get; set; } = null!;
    }
}
