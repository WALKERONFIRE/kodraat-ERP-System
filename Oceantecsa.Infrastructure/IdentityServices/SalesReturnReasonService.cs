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
    public class SalesReturnReasonService: ISalesReturnReasonService
    {
        private readonly IDevelopERPContext _context;

        public SalesReturnReasonService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SalesReturnReason>> GetAll()
        {
            return await _context.SalesReturnReasons.ToListAsync();
        }

        public async Task<SalesReturnReason> GetById(int id)
        {
            return await _context.SalesReturnReasons.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<SalesReturnReason> Add(SalesReturnReason salesReturnReason)
        {
            await _context.SalesReturnReasons.AddAsync(salesReturnReason);
            _context.SaveChanges();
            return salesReturnReason;
        }

        public SalesReturnReason Delete(SalesReturnReason salesReturnReason)
        {
            salesReturnReason.IsDeleted = true;
            salesReturnReason.Active = false;
            _context.SaveChanges();
            return salesReturnReason;
        }



        public SalesReturnReason Update(SalesReturnReason salesReturnReason)
        {
            _context.Update(salesReturnReason);
            _context.SaveChanges();
            return salesReturnReason;
        }

        public bool SalesReturnReasonExists(int id)
        {
            return _context.SalesReturnReasons.Any(e => e.Id == id);

        }
    }
}
