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
    public class CustomerActivityService:ICustomerActivitySevice
    {
        private readonly IDevelopERPContext _context;

        public CustomerActivityService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CustomerActivity>> GetAll()
        {
            return await _context.CustomerActivities.ToListAsync();
        }

        public async Task<CustomerActivity> GetById(int id)
        {
            return await _context.CustomerActivities.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<CustomerActivity> Add(CustomerActivity customerActivity)
        {
            await _context.CustomerActivities.AddAsync(customerActivity);
            _context.SaveChanges();
            return customerActivity;
        }

        public CustomerActivity Delete(CustomerActivity customerActivity)
        {
            customerActivity.IsDeleted = true;
            customerActivity.Active = false;
            _context.SaveChanges();
            return customerActivity;
        }



        public CustomerActivity Update(CustomerActivity customerActivity)
        {
            _context.Update(customerActivity);
            _context.SaveChanges();
            return customerActivity;
        }

        public bool CustomerActivityExists(int id)
        {
            return _context.CustomerActivities.Any(e => e.Id == id);

        }
    }
}
