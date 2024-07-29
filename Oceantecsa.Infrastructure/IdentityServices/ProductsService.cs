using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
namespace Oceantecsa.Infrastructure.IdentityServices
{
	public class ProductsService : IProductsService
	{
		private readonly IDevelopERPContext _context;

		public ProductsService(IDevelopERPContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Product>> GetAll()
		{
			return await _context.Products

				.Include(x => x.ProductUnitPrice)
				.ToListAsync();
		}

		public async Task<Product> GetById(long id)
		{
			return await _context.Products.Include(x => x.ProductUnitPrice).FirstOrDefaultAsync(m => m.Id == id);
		}
		public async Task<Product> Add(Product product)
		{
			await _context.Products.AddAsync(product);
			_context.SaveChanges();
			return product;
		}

		public Product Delete(Product product)
		{
			_context.Remove(product);
			_context.SaveChanges();
			return product;
		}

		public Product Update(Product product)
		{
			_context.Update(product);
			_context.SaveChanges();
			return product;
		}

		public bool ProductExists(long id)
		{
			return _context.Products.Any(e => e.Id == id);
		}

		public string GenerateProductCode()
		{
			// Implement your code generation logic here
			return Guid.NewGuid().ToString("N");
		}

		
	}
}
