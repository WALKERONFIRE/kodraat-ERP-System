using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ITransactionOutTypeService
    {
        List<TransactionOutType> GetAllTransactionOutTypes();
        TransactionOutType GetTransactionOutType(int id);
        void AddTransactionOutType(TransactionOutTypeDTO cost);
        void DeleteTransactionOutType(int id);
        void UpdateTransactionOutType(int id, TransactionOutTypeDTO costing);
    }
}
