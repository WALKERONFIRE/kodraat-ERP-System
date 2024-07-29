using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
	public class WarehouseDto
	{
		public int Id { get; set; }
		public string EnglishName { get; set; } = null!;
		public string ArabicName { get; set; } = null!;
		public string Description { get; set; } = null!;
		public int WarehouseTypeId { get; set; }
		public int BranchId { get; set; }
		public int CostingTypeId { get; set; }
		public long AccountId { get; set; }
		public bool Active { get; set; }
		public bool IsDeleted { get; set; }
	}
}
