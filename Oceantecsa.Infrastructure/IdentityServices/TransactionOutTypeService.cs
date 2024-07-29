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
    public class TransactionOutTypeService : ITransactionOutTypeService
    {
        private readonly IDevelopERPContext _context;

        public TransactionOutTypeService(IDevelopERPContext context)
        {
            _context = context;
        }

        public List<TransactionOutType> GetAllTransactionOutTypes()
        {
            return _context.TransactionOutTypes.Where(d => !d.IsDeleted).ToList();
        }

        public TransactionOutType GetTransactionOutType(int id)
        {
            return _context.TransactionOutTypes.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
        }

        public void AddTransactionOutType(TransactionOutTypeDTO cost)
        {
            var type = new TransactionOutType
            {
                Active = true,
                ArabicName = cost.ArabicName,
                Description = cost.Description,
                EnglishName = cost.EnglishName,
                IsDeleted = false,
            };
            _context.TransactionOutTypes.Add(type);
            _context.SaveChanges();
        }

        public void DeleteTransactionOutType(int id)
        {
            var type = _context.TransactionOutTypes.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
            if (type != null)
            {
                type.Active = false;
                type.IsDeleted = true;
                _context.SaveChanges();
            }
        }

        public void UpdateTransactionOutType(int id, TransactionOutTypeDTO costing)
        {
            var type = _context.TransactionOutTypes.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
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
