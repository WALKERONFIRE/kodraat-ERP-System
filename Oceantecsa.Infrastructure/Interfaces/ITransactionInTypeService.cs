using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ITransactionInTypeService
    {
        List<TransactionInType> GetAllTransactionInTypes();
        TransactionInType GetTransactionInType(int id);
        void AddTransactionInType(TransactionInTypeDTO cost);
        void DeleteTransactionInType(int id);
        void UpdateTransactionInType(int id, TransactionInTypeDTO costing);
    }

}
