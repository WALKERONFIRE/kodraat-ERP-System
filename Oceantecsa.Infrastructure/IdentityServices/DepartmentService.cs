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
    public class DepartmentService : IDepartmentService
    {
        private readonly IDevelopERPContext _context;

        public DepartmentService(IDevelopERPContext context)
        {
            _context = context;
        }

        public List<Department> GetAllDepartments()
        {
            return _context.Departments.Where(d => !d.IsDeleted).ToList();
        }

        public Department GetDepartment(int id)
        {
            return _context.Departments.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
        }

        public void AddDepartment(DepartmentDTO department)
        {
            var department1 = new Department
            {
                Active = true,
                ArabicName = department.ArabicName,
                CostCenterId = department.CostCenterId,
                Description = department.Description,
                EnglishName = department.EnglishName,
                IsDeleted = false,
            };
            _context.Departments.Add(department1);
            _context.SaveChanges();
        }

        public void DeleteDepartment(int id)
        {
            var department = _context.Departments.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
            if (department != null)
            {
                department.Active = false;
                department.IsDeleted = true;
                _context.SaveChanges();
            }
        }

        public void UpdateDepartment(int id, DepartmentDTO department)
        {
            var existingDepartment = _context.Departments.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
            if (existingDepartment != null && existingDepartment.Active)
            {
                existingDepartment.Active = true;
                existingDepartment.ArabicName = department.ArabicName;
                existingDepartment.CostCenterId = department.CostCenterId;
                existingDepartment.Description = department.Description;
                existingDepartment.EnglishName = department.EnglishName;
                existingDepartment.IsDeleted = false;
                existingDepartment.Employees = existingDepartment.Employees ?? null;
                existingDepartment.Sections = existingDepartment.Sections ?? null;
                _context.SaveChanges();
            }
        }
    }
}