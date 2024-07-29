﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Filters
{
	public class PaginationFilter
	{
		public int PageNumber { get; set; }
		public float PageSize { get; set; }

		public PaginationFilter()
		{
			this.PageNumber = 1;
			this.PageSize = 10f;
		}
		public PaginationFilter(int pageNumber, float pageSize)
		{
			this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
			this.PageSize = pageSize > 10 ? 10 : pageSize;
		}
	}
}
