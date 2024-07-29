using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface ISupplierTypesService
	{
		Task<IEnumerable<SupplierType>> GetAll();
		Task<SupplierType> GetById(int id);

		Task<SupplierType> Add(SupplierType Type);
		SupplierType Update(SupplierType Type);
		SupplierType Delete(SupplierType Type);

		bool TypeExists(int id);
	}
}
