using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public class CostingTypeService : ICostingTypeService
    {
        private readonly IDevelopERPContext _context;

        public CostingTypeService(IDevelopERPContext context)
        {
            _context = context;
        }

        public List<CostingType> GetAllCostingTypes()
        {
            return _context.CostingTypes.Where(d => !d.IsDeleted).ToList();
        }

        public CostingType GetCostingType(int id)
        {
            return _context.CostingTypes.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
        }

        public void AddCostingType(CostingTypeDTO cost)
        {
            var type = new CostingType
            {
                Active = true,
                ArabicName = cost.ArabicName,
                Description = cost.Description,
                EnglishName = cost.EnglishName,
                IsDeleted = false,
            };
            _context.CostingTypes.Add(type);
            _context.SaveChanges();
        }

        public void DeleteCostingType(int id)
        {
            var type = _context.CostingTypes.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
            if (type != null)
            {
                type.Active = false;
                type.IsDeleted = true;
                _context.SaveChanges();
            }
        }

        public void UpdateCostingType(int id, CostingTypeDTO costing)
        {
            var type = _context.CostingTypes.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
            if (type != null)
            {
                type.Active = true;
                type.ArabicName = costing.ArabicName;
                type.Description = costing.Description;
                type.EnglishName = costing.EnglishName;
                type.IsDeleted = false;
                _context.SaveChanges();
            }
        }
    }
}
