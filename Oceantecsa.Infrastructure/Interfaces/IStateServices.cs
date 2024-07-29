using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IStateServices
    {
        IEnumerable<State> GetAllStates();
        State GetState(int id);
        void AddState(StateDTO state);
        bool UpdateState(int id, StateDTO state);
        bool RemoveState(int id);
    }
}
