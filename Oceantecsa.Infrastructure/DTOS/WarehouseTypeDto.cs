using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
	public class WarehouseTypeDto
	{
		public int Id { get; set; }
		public string EnglishName { get; set; } = null!;
		public string ArabicName { get; set; } = null!;
		public string Description { get; set; } = null!;
		public bool Active { get; set; }
		public bool IsDeleted { get; set; }
	}
}
