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
    public class ShelfService : IShelfService
    {
        private readonly IDevelopERPContext _context;

        public ShelfService(IDevelopERPContext context)
        {
            _context = context;
        }

        public List<Shelf> GetAllShelves()
        {
            return _context.Shelves.Where(d => !d.IsDeleted).ToList();
        }

        public Shelf GetShelf(int id)
        {
            return _context.Shelves.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
        }

        public void AddShelf(ShelfDTO shelf)
        {
            Shelf shelfEntity = new Shelf
            {
                Active = true,
                ArabicName = shelf.ArabicName,
                Description = shelf.Description,
                EnglishName = shelf.EnglishName,
                IsDeleted = false,
                DivisionId = shelf.DivisionId
            };
            _context.Shelves.Add(shelfEntity);
            _context.SaveChanges();
        }

        public void DeleteShelf(int id)
        {
            var shelf = _context.Shelves.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
            if (shelf != null)
            {
                shelf.Active = false;
                shelf.IsDeleted = true;
                _context.SaveChanges();
            }
        }

        public void UpdateShelf(int id, ShelfDTO shelf)
        {
            var existingShelf = _context.Shelves.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
            if (existingShelf != null && existingShelf.Active)
            {
                existingShelf.ArabicName = shelf.ArabicName;
                existingShelf.Description = shelf.Description;
                existingShelf.EnglishName = shelf.EnglishName;
                existingShelf.DivisionId = shelf.DivisionId;

                _context.SaveChanges();
            }
        }
    }
}
