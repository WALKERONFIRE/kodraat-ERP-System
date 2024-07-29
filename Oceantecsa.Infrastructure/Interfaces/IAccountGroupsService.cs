using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IAccountGroupsService
    {
        Task<IEnumerable<AccountGroup>> GetAll();

        Task<AccountGroup> GetById(int id);

        Task<AccountGroup> Add(AccountGroup accountGroup);
        AccountGroup Update(AccountGroup accountGroup);
        AccountGroup Delete(AccountGroup accountGroup);

        bool AccountGroupExists(int id);
    }
}
