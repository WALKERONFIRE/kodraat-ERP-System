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
    public class PaymentTypeService: IPaymentTypeService
    {
        private readonly IDevelopERPContext _context;

        public PaymentTypeService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaymentType>> GetAll()
        {
            return await _context.PaymentTypes.ToListAsync();
        }

        public async Task<PaymentType> GetById(int id)
        {
            return await _context.PaymentTypes.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<PaymentType> Add(PaymentType paymentType)
        {
            await _context.PaymentTypes.AddAsync(paymentType);
            await _context.SaveChangesAsync();
            return paymentType;
        }

        public PaymentType Delete(PaymentType paymentType)
        {
            paymentType.IsDeleted = true;
            paymentType.Active = false;
            _context.SaveChanges();
            return paymentType;
        }



        public PaymentType Update(PaymentType paymentType)
        {
            _context.Update(paymentType);
            _context.SaveChanges();
            return paymentType;
        }

        public bool PaymentTypeExists(int id)
        {
            return _context.PaymentTypes.Any(e => e.Id == id);

        }
    }
}
