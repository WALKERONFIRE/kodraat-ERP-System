using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oceantecsa.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Oceantecsa.Infrastructure.IdentityServices
{
    public class AccountSettingsService: IAccountSettingsService
    {
        private readonly IDevelopERPContext _context;

        public AccountSettingsService(IDevelopERPContext context)
        {
            _context = context;
        }
        public bool AccountExists(int id)
        {
            return _context.AccountingSettings.Any(e => e.Id == id);
        }

        public async Task<AccountingSetting> Add(AccountingSetting accountSettings)
        {
            await _context.AccountingSettings.AddAsync(accountSettings);
            await _context.SaveChangesAsync();
            return accountSettings;
        }

        public AccountingSetting Delete(AccountingSetting accountSettings)
        {
            accountSettings.IsDeleted = true;
            accountSettings.Active = false;
            _context.SaveChanges();
            return accountSettings;
        }

        public async Task<IEnumerable<AccountingSetting>> GetAll()
        {
            var accountsSettings = await _context.AccountingSettings.ToListAsync();
            return accountsSettings;
        }

        public async Task<AccountingSetting> GetById(int id)
        {
            var accountSettings = await _context.AccountingSettings.FirstOrDefaultAsync(e => e.Id == id);
            return accountSettings;
        }

        public AccountingSetting Update(AccountingSetting accountSettings)
        {
            _context.AccountingSettings.Update(accountSettings);
            _context.SaveChanges();
            return accountSettings;
        }
    }
}
