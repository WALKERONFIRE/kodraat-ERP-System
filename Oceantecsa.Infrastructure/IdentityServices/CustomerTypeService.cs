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
    public class CustomerTypeService:ICustomerTypeService
    {
        private readonly IDevelopERPContext _context;

        public CustomerTypeService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CustomerType>> GetAll()
        {
            return await _context.CustomerTypes.ToListAsync();
        }

        public async Task<CustomerType> GetById(int id)
        {
            return await _context.CustomerTypes.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<CustomerType> Add(CustomerType customerType)
        {
            await _context.CustomerTypes.AddAsync(customerType);
            _context.SaveChanges();
            return customerType;
        }

        public CustomerType Delete(CustomerType customerType)
        {
            customerType.IsDeleted = true;
            customerType.Active = false;
            _context.SaveChanges();
            return customerType;
        }



        public CustomerType Update(CustomerType customerType)
        {
            _context.Update(customerType);
            _context.SaveChanges();
            return customerType;
        }

        public bool CustomerTypeExists(int id)
        {
            return _context.CustomerTypes.Any(e => e.Id == id);

        }
    }
}
