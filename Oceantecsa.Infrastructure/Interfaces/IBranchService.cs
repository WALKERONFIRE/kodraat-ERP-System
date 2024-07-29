
using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IBranchService
    {
        Task<IEnumerable<Branch>> GetAll();

        Task<Branch> GetById(int id);

        Task<Branch> Add(Branch branch);
        Branch Update(Branch branch);
        Branch Delete(Branch branch);

        bool BranchExists(int id);
    }
}
