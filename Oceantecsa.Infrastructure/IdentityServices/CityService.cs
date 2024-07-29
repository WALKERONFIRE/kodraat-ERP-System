using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
    public class CityService:ICityService
    {
        private readonly IDevelopERPContext _context;

        public CityService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetAll()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<City> GetById(int id)
        {
            return await _context.Cities.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<City> Add(City city)
        {
            await _context.Cities.AddAsync(city);
            _context.SaveChanges();
            return city;
        }

        public City Delete(City city)
        {
            city.IsDeleted = true;
            city.Active = false;
            _context.SaveChanges();
            return city;
        }



        public City Update(City city)
        {
            _context.Update(city);
            _context.SaveChanges();
            return city;
        }

        public bool CityExists(int id)
        {
            return _context.Cities.Any(e => e.Id == id);

        }
    }
}
