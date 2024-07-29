using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ICustomerSerivce
    {
        Task<IEnumerable<Customer>> GetAll();

        Task<Customer> GetById(int id);

        Task<Customer> Add(Customer customer);
        Customer Update(Customer customer);
        Customer Delete(Customer customer);

        bool CustomerExists(int id);
    }
}
