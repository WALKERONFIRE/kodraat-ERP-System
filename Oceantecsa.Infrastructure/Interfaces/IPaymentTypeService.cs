using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IPaymentTypeService
    {
        Task<IEnumerable<PaymentType>> GetAll();

        Task<PaymentType> GetById(int id);

        Task<PaymentType> Add(PaymentType paymentType);
        PaymentType Update(PaymentType paymentType);
        PaymentType Delete(PaymentType paymentType);

        bool PaymentTypeExists(int id);
    }
}
