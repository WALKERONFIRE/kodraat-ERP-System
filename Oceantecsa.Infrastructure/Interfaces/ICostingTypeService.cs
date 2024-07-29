using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ICostingTypeService
    {
        List<CostingType> GetAllCostingTypes();
        CostingType GetCostingType(int id);
        void AddCostingType(CostingTypeDTO cost);
        void DeleteCostingType(int id);
        void UpdateCostingType(int id, CostingTypeDTO costing);
    }
}
