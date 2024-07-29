using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOs
{
	public class FinancialPeriodHdrDto
	{
		public int Id { get; set; }
		public int CompanyId { get; set; }
		public int Year { get; set; }
		public int Count { get; set; }
		public DateTime PeriodStart { get; set; }
		public DateTime PeriodEnd { get; set; }
		public string Description { get; set; } = null!;
		public bool Posted { get; set; }
		public bool Locked { get; set; }
		public DateTime CreatedDate { get; set; }
		public int CreatedUser { get; set; }
		public DateTime ModifiedDate { get; set; }
		public int ModifiedUser { get; set; }
		public DateTime PostedDate { get; set; }
		public int PostedUser { get; set; }
		public bool Active { get; set; }
		public bool IsDeleted { get; set; }
	}
}
