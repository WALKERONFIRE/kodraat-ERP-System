using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.DTOs
{
	public class PaymentReport
	{
		public double TotalPrice { get; set; }
		public virtual ICollection<PaymentReportDtl> PaymentReportDtl { get; set; }
	}
}
