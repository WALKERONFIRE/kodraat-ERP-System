using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface IProductUnitPricesService
	{
		Task<IEnumerable<ProductUnitPrice>> GetAll();

		Task<ProductUnitPrice> GetById(int id);
		//Task AddRange(List<ProductUnitPrice> productUnitPrices);
		Task<ProductUnitPrice> Add(ProductUnitPrice pup);
		ProductUnitPrice Update(ProductUnitPrice pup);
		ProductUnitPrice Delete(ProductUnitPrice pup);

	
	}
}
