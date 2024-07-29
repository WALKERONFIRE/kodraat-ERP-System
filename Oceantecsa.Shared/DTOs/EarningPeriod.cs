using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.DTOs
{
	public class EarningPeriod
	{
		public decimal TotalPrice { get; set; }
		public virtual ICollection<EarningPeriodDtl> EarningPeriodDtl { get; set; }
	}
}
