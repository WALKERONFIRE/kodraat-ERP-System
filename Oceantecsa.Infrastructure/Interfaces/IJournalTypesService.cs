using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface IJournalTypesService
	{
		Task<IEnumerable<JournalType>> GetAll();
		Task<JournalType> GetById(int id);

		Task<JournalType> Add(JournalType type);
		JournalType Update(JournalType type);
		JournalType Delete(JournalType type);

		bool TypeExists(int id);
	}
}
