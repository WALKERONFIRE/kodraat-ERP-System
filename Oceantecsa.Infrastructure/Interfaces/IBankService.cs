using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IBankService
    {
        Task<IEnumerable<Bank>> GetAll();

        Task<Bank> GetById(int id);

        Task<Bank> Add(Bank bank);
        Bank Update(Bank bank);
        Bank Delete(Bank bank);

        bool BankExists(int id);
    }
}
