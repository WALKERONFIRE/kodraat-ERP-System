using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOs
{
	public class AccountActivityDto
	{
		public long Id { get; set; }

		public long ParentId { get; set; }
		public string EnglishName { get; set; }
		public string ArabicName { get; set; }
		public string Description { get; set; }
		public bool HaveSub { get; set; }
		public int ActivityLevel { get; set; }
		public bool Active { get; set; }
		public bool IsDeleted { get; set; }
	}
}
