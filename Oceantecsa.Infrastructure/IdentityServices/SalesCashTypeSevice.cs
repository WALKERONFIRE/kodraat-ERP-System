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
    public class SalesCashTypeService: ISalesCashTypeService
    {
        private readonly IDevelopERPContext _context;

        public SalesCashTypeService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SalesCashType>> GetAll()
        {
            return await _context.SalesCashTypes.ToListAsync();
        }

        public async Task<SalesCashType> GetById(int id)
        {
            return await _context.SalesCashTypes.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<SalesCashType> Add(SalesCashType SalesCashType)
        {
            await _context.SalesCashTypes.AddAsync(SalesCashType);
            _context.SaveChanges();
            return SalesCashType;
        }

        public SalesCashType Delete(SalesCashType SalesCashType)
        {
            SalesCashType.IsDeleted = true;
            SalesCashType.Active = false;
            _context.SaveChanges();
            return SalesCashType;
        }



        public SalesCashType Update(SalesCashType SalesCashType)
        {
            _context.Update(SalesCashType);
            _context.SaveChanges();
            return SalesCashType;
        }

        public bool SalesCashTypeExists(int id)
        {
            return _context.SalesCashTypes.Any(e => e.Id == id);

        }
    }
}
