using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
    public class TransactionInTypeService : ITransactionInTypeService
    {
        private readonly IDevelopERPContext _context;

        public TransactionInTypeService(IDevelopERPContext context)
        {
            _context = context;
        }

        public List<TransactionInType> GetAllTransactionInTypes()
        {
            return _context.TransactionInTypes.Where(d => !d.IsDeleted).ToList();
        }

        public TransactionInType GetTransactionInType(int id)
        {
            return _context.TransactionInTypes.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
        }

        public void AddTransactionInType(TransactionInTypeDTO cost)
        {
            var type = new TransactionInType
            {
                Active = true,
                ArabicName = cost.ArabicName,
                Description = cost.Description,
                EnglishName = cost.EnglishName,
                IsDeleted = false,
            };
            _context.TransactionInTypes.Add(type);
            _context.SaveChanges();
        }

        public void DeleteTransactionInType(int id)
        {
            var type = _context.TransactionInTypes.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
            if (type != null)
            {
                type.Active = false;
                type.IsDeleted = true;
                _context.SaveChanges();
            }
        }

        public void UpdateTransactionInType(int id, TransactionInTypeDTO costing)
        {
            var type = _context.TransactionInTypes.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
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
