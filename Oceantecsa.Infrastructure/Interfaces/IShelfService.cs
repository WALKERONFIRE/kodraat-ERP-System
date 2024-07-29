using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IShelfService
    {
        List<Shelf> GetAllShelves();
        Shelf GetShelf(int id);
        void AddShelf(ShelfDTO shelf);
        void DeleteShelf(int id);
        void UpdateShelf(int id, ShelfDTO shelf);
    }
}
