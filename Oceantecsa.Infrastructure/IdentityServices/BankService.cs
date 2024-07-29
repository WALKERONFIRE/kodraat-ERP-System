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
    public class BankService: IBankService
    {
        private readonly IDevelopERPContext _context;

        public BankService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Bank>> GetAll()
        {
            return await _context.Banks.ToListAsync();
        }

        public async Task<Bank> GetById(int id)
        {
            return await _context.Banks.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<Bank> Add(Bank bank)
        {
            await _context.Banks.AddAsync(bank);
            _context.SaveChanges();
            return bank;
        }

        public Bank Delete(Bank bank)
        {
            bank.IsDeleted = true;
            bank.Active = false;
            _context.SaveChanges();
            return bank;
        }



        public Bank Update(Bank bank)
        {
            _context.Update(bank);
            _context.SaveChanges();
            return bank;
        }

        public bool BankExists(int id)
        {
            return _context.Banks.Any(e => e.Id == id);

        }
    }
}
