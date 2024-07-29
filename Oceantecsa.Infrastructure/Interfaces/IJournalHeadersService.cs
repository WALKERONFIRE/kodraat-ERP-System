using Oceantecsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
	public interface IJournalHeadersService
	{
		Task<IEnumerable<JournalHdr>> GetAll();

		Task<JournalHdr> GetById(long id);

		Task<JournalHdr> Add(JournalHdr Header);

		JournalHdr Update(JournalHdr Header);

		JournalHdr Delete(JournalHdr Header);

		bool JounralExists(long id);
	}
}
