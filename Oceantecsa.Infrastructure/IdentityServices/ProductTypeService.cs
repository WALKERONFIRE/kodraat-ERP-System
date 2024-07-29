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
    public class ProductTypeService: IProductTypeService
    {
        private readonly IDevelopERPContext _context;

        public ProductTypeService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductType>> GetAll()
        {
            return await _context.ProductTypes.ToListAsync();
        }

        public async Task<ProductType> GetById(int id)
        {
            return await _context.ProductTypes.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<ProductType> Add(ProductType productType)
        {
            await _context.ProductTypes.AddAsync(productType);
            _context.SaveChanges();
            return productType;
        }

        public ProductType Delete(ProductType productType)
        {
            productType.IsDeleted = true;
            productType.Active = false;
            _context.SaveChanges();
            return productType;
        }



        public ProductType Update(ProductType productType)
        {
            _context.Update(productType);
            _context.SaveChanges();
            return productType;
        }

        public bool ProductTypeExists(int id)
        {
            return _context.ProductTypes.Any(e => e.Id == id);

        }
    }
}
