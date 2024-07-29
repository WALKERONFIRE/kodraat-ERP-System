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
    public class TransactionInDtlService: ITransactionInDtlService
    {
        private readonly IDevelopERPContext _context;

        public TransactionInDtlService(IDevelopERPContext context)
        {
            _context = context;
        }

        public TransactionInDtl AddTransactionInDtl(TransactionInDtl transactionInDtl)
        {
            _context.TransactionInDtls.Add(transactionInDtl);
            _context.SaveChanges();
            return transactionInDtl;
        }
        public TransactionInDtl GetTransactionInDtl(long TransactionInHdrId)
        {
            var transactionInDtl = _context.TransactionInDtls.FirstOrDefault(e => e.TransactionInHdrId == TransactionInHdrId);
            return transactionInDtl;
        }

        public void DeleteTransactionInDtl(long id)
        {
            var transactionInDtl = GetTransactionInDtl(id);
            transactionInDtl.IsDeleted = true;
            _context.SaveChanges();
        }

        public void UpdateTransactionInDtl(TransactionInDtl transactionInDtl)
        {
            _context.TransactionInDtls.Update(transactionInDtl);
            _context.SaveChanges();
        }
    }
}
