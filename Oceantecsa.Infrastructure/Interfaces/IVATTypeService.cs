using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IVATTypeService
    {
        Task<IEnumerable<Vattype>> GetAll();

        Task<Vattype> GetById(int id);

        Task<Vattype> Add(Vattype vattype);
        Vattype Update(Vattype vattype);
        Vattype Delete(Vattype vattype);

        bool VattypeExists(int id);
    }
}
