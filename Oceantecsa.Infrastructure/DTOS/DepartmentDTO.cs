using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS
{
    public class DepartmentDTO
    {

        //public DepartmentDTO()
        //{
        //    Employees = new HashSet<Employee>();
        //    Sections = new HashSet<Section>();
        //}
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long CostCenterId { get; set; }

        //public virtual ICollection<Employee>? Employees { get; set; }
        //public virtual ICollection<Section>? Sections { get; set; }
    }
}
