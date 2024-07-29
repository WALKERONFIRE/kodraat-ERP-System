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
    public class BranchService:IBranchService
    {
        private readonly IDevelopERPContext _context;

        public BranchService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Branch>> GetAll()
        {
            return await _context.Branches.ToListAsync();
        }

        public async Task<Branch> GetById(int id)
        {
            return await _context.Branches.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<Branch> Add(Branch Branch)
        {
            await _context.Branches.AddAsync(Branch);
            _context.SaveChanges();
            return Branch;
        }

        public Branch Delete(Branch Branch)
        {
            Branch.IsDeleted = true;
            Branch.Active = false;
            _context.SaveChanges();
            return Branch;
        }



        public Branch Update(Branch Branch)
        {
            _context.Update(Branch);
            _context.SaveChanges();
            return Branch;
        }

        public bool BranchExists(int id)
        {
            return _context.Branches.Any(e => e.Id == id);

        }
    }
}
