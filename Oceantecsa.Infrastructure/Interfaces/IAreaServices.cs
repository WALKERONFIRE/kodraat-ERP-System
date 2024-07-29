using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IAreaServices
    {
        IEnumerable<Area> GetAllAreas();
        Area GetArea(int id);
        void AddArea(AreaDTO area);
        void UpdateArea(int id, AreaDTO area);
        void RemoveArea(int id);
    }
}
