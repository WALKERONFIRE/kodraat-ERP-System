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
    public class ProductionTypeService : IProductionTypeService
    {
        private readonly IDevelopERPContext _context;

        public ProductionTypeService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductProductionType>> GetAll()
        {
            return await _context.ProductProductionTypes.ToListAsync();
        }

        public async Task<ProductProductionType> GetById(int id)
        {
            return await _context.ProductProductionTypes.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<ProductProductionType> Add(ProductProductionType productProductionType)
        {
            await _context.ProductProductionTypes.AddAsync(productProductionType);
            _context.SaveChanges();
            return productProductionType;
        }

        public ProductProductionType Delete(ProductProductionType productProductionType)
        {
            productProductionType.IsDeleted = true;
            productProductionType.Active = false;
            _context.SaveChanges();
            return productProductionType;
        }



        public ProductProductionType Update(ProductProductionType productProductionType)
        {
            _context.Update(productProductionType);
            _context.SaveChanges();
            return productProductionType;
        }

        public bool ProductProductionTypeExists(int id)
        {
            return _context.ProductProductionTypes.Any(e => e.Id == id);

        }
    }
 }
