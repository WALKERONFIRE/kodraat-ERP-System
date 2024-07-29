using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Wrappers
{
	public class PagedResponse<T> : Response<T>
	{
		public int PageNumber { get; set; }
		public float PageSize { get; set; }
		public double TotalPages { get; set; }
		public int TotalRecords { get; set; }
	
		//public string PrevPageLink { get; set; } // Add this property
		//public string NextPageLink { get; set; } // Add this property



		public PagedResponse(T data, int pageNumber, float pageSize , int totalRecords, double totalPages)
		{
			this.PageNumber = pageNumber;
			this.PageSize = pageSize;
			this.TotalRecords = totalRecords;
			this.Data = data;
			this.Message = null;
			this.Succeeded = true;
			this.Errors = null;
			this.TotalPages = totalPages;
		}
	}
}
