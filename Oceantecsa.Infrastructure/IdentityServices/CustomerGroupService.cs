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
    public class CustomerGroupService:ICustomerGroupService
    {
        private readonly IDevelopERPContext _context;

        public CustomerGroupService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CustomerGroup>> GetAll()
        {
            return await _context.CustomerGroups.ToListAsync();
        }

        public async Task<CustomerGroup> GetById(int id)
        {
            return await _context.CustomerGroups.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<CustomerGroup> Add(CustomerGroup customerGroup)
        {
            await _context.CustomerGroups.AddAsync(customerGroup);
            _context.SaveChanges();
            return customerGroup;
        }

        public CustomerGroup Delete(CustomerGroup customerGroup)
        {
            customerGroup.IsDeleted = true;
            customerGroup.Active = false;
            _context.SaveChanges();
            return customerGroup;
        }



        public CustomerGroup Update(CustomerGroup customerGroup)
        {
            _context.Update(customerGroup);
            _context.SaveChanges();
            return customerGroup;
        }

        public bool CustomerGroupExists(int id)
        {
            return _context.CustomerGroups.Any(e => e.Id == id);

        }
    }
}
