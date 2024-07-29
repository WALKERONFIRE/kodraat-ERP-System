using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface IProductsService
	{
		Task<IEnumerable<Product>> GetAll();

		Task<Product> GetById(long id);

		Task<Product> Add(Product product);
		Product Update(Product product);
		Product Delete(Product product);

		bool ProductExists(long id);
		string GenerateProductCode();

	}
}
