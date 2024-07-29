using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IAccountSettingsService
    {
        Task<IEnumerable<AccountingSetting>> GetAll();

        Task<AccountingSetting> GetById(int id);

        Task<AccountingSetting> Add(AccountingSetting accountSettings);
        AccountingSetting Update(AccountingSetting accountSettings);
        AccountingSetting Delete(AccountingSetting accountSettings);

        bool AccountExists(int id);
    }
}
