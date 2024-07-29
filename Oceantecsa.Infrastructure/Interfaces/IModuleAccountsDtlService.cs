using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using OceantecsaAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IModuleAccountsDtlService
    {
        Task<IEnumerable<ModuleAccountsDtl>> GetById(int ModuleAccountsHdrId);

        Task<ModuleAccountsDtl> Add(int accountsHdrId, ModuleAccountsDtlDto accountsDtl);
        ModuleAccountsDtl Update(int id,int accountsHdrId,ModuleAccountsDtlDto moduleAccounts);
    }
}
