using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ITransactionInDtlService
    {
        TransactionInDtl AddTransactionInDtl(TransactionInDtl transactionInDtl);
        TransactionInDtl GetTransactionInDtl(long TransactionInHdrId);
        void UpdateTransactionInDtl( TransactionInDtl transactionInDtl);
        void DeleteTransactionInDtl(long id);
    }
}
