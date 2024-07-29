using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ICustomerActivitySevice
    {
        Task<IEnumerable<CustomerActivity>> GetAll();

        Task<CustomerActivity> GetById(int id);

        Task<CustomerActivity> Add(CustomerActivity CustomerActivity);
        CustomerActivity Update(CustomerActivity customerActivity);
        CustomerActivity Delete(CustomerActivity customerActivity);

        bool CustomerActivityExists(int id);
    }
}
