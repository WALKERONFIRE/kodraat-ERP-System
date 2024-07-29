using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
	public class ProductUnitPricesService : IProductUnitPricesService
	{
		private readonly IDevelopERPContext _context;

		public ProductUnitPricesService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<ProductUnitPrice>> GetAll()
		{
			throw new NotImplementedException();
		}
		public async Task<ProductUnitPrice> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<ProductUnitPrice> Add(ProductUnitPrice pup)
		{
			await _context.ProductUnitPrices.AddAsync(pup);
			_context.SaveChanges();
			return pup;
		}

		public ProductUnitPrice Delete(ProductUnitPrice pup)
		{
			throw new NotImplementedException();
		}

		public ProductUnitPrice Update(ProductUnitPrice pup)
		{
			throw new NotImplementedException();
		}

		//public async Task AddRange(List<ProductUnitPrice> productUnitPrices)
		//{
		//	_context.ProductUnitPrices.AddRange(productUnitPrices);
		//	await _context.SaveChangesAsync();
		//}
	}
}
