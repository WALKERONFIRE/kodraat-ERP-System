using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
    public class StateServices : IStateServices
    {
        private readonly IDevelopERPContext _context;

        public StateServices(IDevelopERPContext context)
        {
            _context = context;
        }

        public IEnumerable<State> GetAllStates()
        {
            return _context.States.Where(x => !x.IsDeleted).ToList();
        }

        public State GetState(int id)
        {
            return _context.States.FirstOrDefault(x => x.Id == id);
        }

        public void AddState(StateDTO state)
        {
            var add = new State()
            {
                Active = true,
                ArabicName = state.ArabicName,
                Description = state.Description,
                EnglishName = state.EnglishName,
                CountryId = state.CountryId,
                IsDeleted = false,
                Cities = null,
                Country = null,
            };
            _context.States.Add(add);
            _context.SaveChanges();
        }

        public bool UpdateState(int id, StateDTO state)
        {
            var existingState = _context.States.FirstOrDefault(x => x.Id == id);
            if (existingState != null)
            {
                // Update the properties of the existingState entity based on the state DTO
                existingState.Active = true;
                existingState.ArabicName = state.ArabicName;
                existingState.Description = state.Description;
                existingState.EnglishName = state.EnglishName;
                existingState.CountryId = state.CountryId;
                existingState.IsDeleted = false;

                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool RemoveState(int id)
        {
            var existingState = _context.States.FirstOrDefault(x => x.Id == id);
            if (existingState != null)
            {
                // Update the properties of the existingState entity
                existingState.Active = false;
                existingState.IsDeleted = true;

                _context.SaveChanges();
                return true;
            }
            return false;
        }

    }

}
