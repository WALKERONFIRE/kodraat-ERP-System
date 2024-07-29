using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oceantecsa.Domain.Models;
namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface ISectionServices
    {
        IEnumerable<Section> GetAllSections();
        Section GetSection(int id);
        void AddSection(SectionDTO section);
        bool UpdateSection(int id, SectionDTO section);
        bool RemoveSection(int id);
    }
}
