using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IDepartmentService
    {
        List<Department> GetAllDepartments();
        Department GetDepartment(int id);
        void AddDepartment(DepartmentDTO department);
        void DeleteDepartment(int id);
        void UpdateDepartment(int id, DepartmentDTO department);
    }
}
