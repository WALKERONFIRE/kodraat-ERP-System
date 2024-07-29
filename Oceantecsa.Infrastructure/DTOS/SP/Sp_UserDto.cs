using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS.SP
{
    public class Sp_UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }
        public int UserGroupId { get; set; }
        public int Language { get; set; }
        public decimal PrepaidValue { get; set; }
        public bool Salesman { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public decimal PrepaidPercent { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal CommissionPercent { get; set; }
        public bool BranchManager { get; set; }

    }
}
