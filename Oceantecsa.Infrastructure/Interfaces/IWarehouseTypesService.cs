using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface IWarehouseTypesService
	{
		Task<IEnumerable<WarehouseType>> GetAll();
		Task<WarehouseType> GetById(int id);

		Task<WarehouseType> Add(WarehouseType Type);
		WarehouseType Update(WarehouseType Type);
		WarehouseType Delete(WarehouseType Type);

		bool TypeExists(int id);
	}
}
