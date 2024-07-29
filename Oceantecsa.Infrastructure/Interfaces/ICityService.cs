using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetAll();

        Task<City> GetById(int id);

        Task<City> Add(City city);
        City Update(City city);
        City Delete(City city);

        bool CityExists(int id);
    }
}
