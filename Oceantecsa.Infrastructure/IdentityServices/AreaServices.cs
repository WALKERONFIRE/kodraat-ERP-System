using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Oceantecsa.Infrastructure.Services
{
    public class AreaServices : IAreaServices
    {
        private readonly IDevelopERPContext _context;

        public AreaServices(IDevelopERPContext context)
        {
            _context = context;
        }

        public IEnumerable<Area> GetAllAreas()
        {
            return _context.Areas.Where(x => !x.IsDeleted).ToList();
        }

        public Area GetArea(int id)
        {
            return _context.Areas.FirstOrDefault(x => x.Id == id);
        }

        public void AddArea(AreaDTO area)
        {
            var add = new Area()
            {
                Active = true,
                ArabicName = area.ArabicName,
                CityId = area.CityId,
                Description = area.Description,
                EnglishName = area.EnglishName,
                IsDeleted = false,
                City = null,
                Drivers = null,
                Salesmen = null
            };
            _context.Areas.Add(add);
            _context.SaveChanges();
        }

        public void UpdateArea(int id, AreaDTO area)
        {
            var check = _context.Areas.FirstOrDefault(x => x.Id == id);
            if (check != null)
            {
                check.ArabicName = area.ArabicName;
                check.CityId = area.CityId;
                check.Description = area.Description;
                check.EnglishName = area.EnglishName;

                // No need to create a new City, Drivers, or Salesmen object.

                _context.SaveChanges();
            }
        }

        public void RemoveArea(int id)
        {
            var check = _context.Areas.FirstOrDefault(x => x.Id == id);
            if (check != null)
            {
                check.Active = false;
                check.IsDeleted = true;

                // No need to create a new City, Drivers, or Salesmen object.

                _context.SaveChanges();
            }
        }

    }
}

