using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ICustomerGroupService
    {
        Task<IEnumerable<CustomerGroup>> GetAll();

        Task<CustomerGroup> GetById(int id);

        Task<CustomerGroup> Add(CustomerGroup customerGroup);
        CustomerGroup Update(CustomerGroup customerGroup);
        CustomerGroup Delete(CustomerGroup customerGroup);

        bool CustomerGroupExists(int id);
    }
}
