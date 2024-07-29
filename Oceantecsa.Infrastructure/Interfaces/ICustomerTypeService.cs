using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ICustomerTypeService
    {
        Task<IEnumerable<CustomerType>> GetAll();

        Task<CustomerType> GetById(int id);

        Task<CustomerType> Add(CustomerType customerType);
        CustomerType Update(CustomerType customerType);
        CustomerType Delete(CustomerType customerType);

        bool CustomerTypeExists(int id);
    }
}
