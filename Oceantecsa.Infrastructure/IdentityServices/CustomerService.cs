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
    public class CustomerService:ICustomerSerivce
    {
        private readonly IDevelopERPContext _context;

        public CustomerService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            return await _context.Customers.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<Customer> Add(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer Delete(Customer customer)
        {
            customer.IsDeleted = true;
            customer.Active = false;
            _context.SaveChanges();
            return customer;
        }



        public Customer Update(Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
            return customer;
        }

        public bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);

        }

    }
}
