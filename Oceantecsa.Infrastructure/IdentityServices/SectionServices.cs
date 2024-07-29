using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System.Linq;

namespace Oceantecsa.Infrastructure.Services
{
    public class SectionServices : ISectionServices
    {
        private readonly IDevelopERPContext _context;

        public SectionServices(IDevelopERPContext context)
        {
            _context = context;
        }

        public IEnumerable<Section> GetAllSections()
        {
            return _context.Sections.Where(x => !x.IsDeleted).ToList();
        }

        public Section GetSection(int id)
        {
            return _context.Sections.FirstOrDefault(x => x.Id == id);
        }

        public void AddSection(SectionDTO section)
        {
            var add = new Section()
            {
                Active = true,
                ArabicName = section.ArabicName,
                CostCenterId = section.CostCenterId,
                DepartmentId = section.DepartmentId,
                Employees = null,
                Department = null,
                Description = section.Description,
                EnglishName = section.EnglishName,
                IsDeleted = false,
            };
            _context.Sections.Add(add);
            _context.SaveChanges();
        }

        public bool UpdateSection(int id, SectionDTO section)
        {
            var existingSection = _context.Sections.FirstOrDefault(x => x.Id == id);
            if (existingSection != null)
            {
                // Update the existing section with values from the 'section' parameter
                existingSection.ArabicName = section.ArabicName;
                existingSection.CostCenterId = section.CostCenterId;
                existingSection.DepartmentId = section.DepartmentId;
                existingSection.Description = section.Description;
                existingSection.EnglishName = section.EnglishName;

                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public bool RemoveSection(int id)
        {
            var existingSection = _context.Sections.FirstOrDefault(x => x.Id == id);
            if (existingSection != null)
            {
                // Mark the existing section as deleted
                existingSection.IsDeleted = true;
                existingSection.Active= false;
                _context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
