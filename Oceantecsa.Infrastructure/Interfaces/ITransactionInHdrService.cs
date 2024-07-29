using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ITransactionInHdrService
    {
        TransactionInHdr AddTransactionInHdr(TransactionInHdr transactionInHdr);
        TransactionInHdr GetTransactionInHdr(long id);
        void UpdateTransactionInHdr(TransactionInHdr transactionInHdr);
        void DeleteTransactionInHdr(long id);
    }
}
