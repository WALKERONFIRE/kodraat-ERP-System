using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using OceantecsaAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
    public class ModuleAccountsDtlService : IModuleAccountsDtlService
    {
        private readonly IDevelopERPContext _context;
        public ModuleAccountsDtlService(IDevelopERPContext context)
        {
            _context = context;
        }
        public async Task<ModuleAccountsDtl> Add(int accountsHdrId, ModuleAccountsDtlDto accountsDtl)
        {
            var moduleDtl = new ModuleAccountsDtl()
            {
                EnglishName = accountsDtl.EnglishName,
                ArabicName = accountsDtl.ArabicName,
                AccountId = accountsDtl.AccountId,
                ModuleAccountsHdrId =(await _context.ModuleAccountsDtls.Where(e=>e.Id== accountsHdrId).MaxAsync(e=>e.ModuleAccountsHdrId))+1,
                Id = accountsHdrId,
                Active = true
            };
            await _context.ModuleAccountsDtls.AddAsync(moduleDtl);
            await _context.SaveChangesAsync();
            return moduleDtl;
        }


        public async Task<IEnumerable<ModuleAccountsDtl>> GetById(int ModuleAccountsHdrId)
        {
            return await _context.ModuleAccountsDtls
                .Where(e => e.Id == ModuleAccountsHdrId)
                .ToListAsync();
        }

        public ModuleAccountsDtl Update(int id,int accountsHdrId,ModuleAccountsDtlDto moduleAccounts)
        {
            var module = _context.ModuleAccountsDtls.Where(e => e.Id == id).FirstOrDefault(e => e.ModuleAccountsHdrId == accountsHdrId);
            
            module.EnglishName = moduleAccounts.EnglishName;
            module.ArabicName = moduleAccounts.ArabicName;
            module.AccountId = moduleAccounts.AccountId;
            module.Active = true;
            _context.ModuleAccountsDtls.Update(module);
            _context.SaveChanges();
            return module;
        }
    }
}
