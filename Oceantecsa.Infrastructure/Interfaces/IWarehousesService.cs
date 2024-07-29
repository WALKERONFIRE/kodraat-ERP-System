using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface IWarehousesService
	{
	    Task<IEnumerable<Warehouse>> GetAll();
		Task<Warehouse> GetById(int id);

		Task<Warehouse> Add(Warehouse Warehouse);
		Warehouse Update(Warehouse Warehouse);
		Warehouse Delete(Warehouse Warehouse);

		bool WarehouseExists(int id);
	}
}
