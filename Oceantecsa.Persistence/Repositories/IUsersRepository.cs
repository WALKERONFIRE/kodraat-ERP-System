using Oceantecsa.Domain.Models;
using Oceantecsa.Shared.Uniteofwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Persistence.Repositories
{
    public interface IUsersRepository : IRepository<User>
    {
    }
}
