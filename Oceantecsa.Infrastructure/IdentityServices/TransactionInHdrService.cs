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
    public class TransactionInHdrService: ITransactionInHdrService
    {
        private readonly IDevelopERPContext _context;

        public TransactionInHdrService(IDevelopERPContext context)
        {
            _context = context;
        }

        public TransactionInHdr AddTransactionInHdr(TransactionInHdr transactionInHdr)
        {
            _context.TransactionInHdrs.Add(transactionInHdr);
            _context.SaveChanges();
            return transactionInHdr;
        }
        public TransactionInHdr GetTransactionInHdr(long id)
        {
            var transactionInHdr = _context.TransactionInHdrs.FirstOrDefault(e => e.Id == id);
            return transactionInHdr;
        }

        public void DeleteTransactionInHdr(long id)
        {
            var transactionInHdr = GetTransactionInHdr(id);
            transactionInHdr.IsDeleted = true;
            _context.SaveChanges();
        }

        public void UpdateTransactionInHdr(TransactionInHdr transactionInHdr)
        {
            _context.TransactionInHdrs.Update(transactionInHdr);
            _context.SaveChanges();
        }
    }
}
