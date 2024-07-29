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
    public class AccountGroupsService: IAccountGroupsService
    {
        private readonly IDevelopERPContext _context;

        public AccountGroupsService(IDevelopERPContext context)
        {
            _context = context;
        }
        public bool AccountGroupExists(int id)
        {
            return _context.AccountGroups.Any(e => e.Id == id);
        }

        public async Task<AccountGroup> Add(AccountGroup accountGroup)
        {
            await _context.AccountGroups.AddAsync(accountGroup);
            await _context.SaveChangesAsync();
            return accountGroup;
        }

        public AccountGroup Delete(AccountGroup accountGroup)
        {
            accountGroup.IsDeleted = true;
            accountGroup.Active = false;
            _context.SaveChanges();
            return accountGroup;
        }

        public async Task<IEnumerable<AccountGroup>> GetAll()
        {
            var accountGroups = await _context.AccountGroups.ToListAsync();
            return accountGroups;
        }

        public async Task<AccountGroup> GetById(int id)
        {
            var accountGroup = await _context.AccountGroups.FirstOrDefaultAsync(e => e.Id == id);
            return accountGroup;
        }

        public AccountGroup Update(AccountGroup accountGroup)
        {
            _context.AccountGroups.Update(accountGroup);
            _context.SaveChanges();
            return accountGroup;
        }
    }
}
