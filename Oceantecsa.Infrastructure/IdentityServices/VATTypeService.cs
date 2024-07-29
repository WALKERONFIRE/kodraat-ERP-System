using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
    public class VATTypeService: IVATTypeService
    {
        private readonly IDevelopERPContext _context;

        public VATTypeService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Vattype>> GetAll()
        {
            return await _context.Vattypes.ToListAsync();
        }

        public async Task<Vattype> GetById(int id)
        {
            return await _context.Vattypes.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<Vattype> Add(Vattype vattype)
        {
            await _context.Vattypes.AddAsync(vattype);
            _context.SaveChanges();
            return vattype;
        }

        public Vattype Delete(Vattype vattype)
        {
            vattype.IsDeleted = true;
            vattype.Active = false;
            _context.SaveChanges();
            return vattype;
        }



        public Vattype Update(Vattype vattype)
        {
            _context.Update(vattype);
            _context.SaveChanges();
            return vattype;
        }

        public bool VattypeExists(int id)
        {
            return _context.Vattypes.Any(e => e.Id == id);

        }
    }
}
