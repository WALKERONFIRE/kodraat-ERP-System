using Microsoft.EntityFrameworkCore;
using Oceantecsa.Infrastructure.DTOs;
using Oceantecsa.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oceantecsa.Persistence.DataContext;
using Oceantecsa.Domain.Models;

namespace Oceantecsa.Infrastructure.IdentityServices
{
    public class MeasurementUnitsService: IMeasurementUnitsService
    {
        private readonly IDevelopERPContext _context;

        public MeasurementUnitsService(IDevelopERPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MeasurementUnit>> GetAll()
        {
            return await _context.MeasurementUnits.ToListAsync();
        }

        public async Task<MeasurementUnit> GetById(int id)
        {
            return await _context.MeasurementUnits.FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task<MeasurementUnit> Add(MeasurementUnit measurementUnit)
        {
            await _context.MeasurementUnits.AddAsync(measurementUnit);
            _context.SaveChanges();
            return measurementUnit;
        }

        public MeasurementUnit Delete(MeasurementUnit measurementUnit)
        {
            measurementUnit.IsDeleted = true;
            measurementUnit.Active = false;
            _context.SaveChanges();
            return measurementUnit;
        }



        public MeasurementUnit Update(MeasurementUnit measurementUnit)
        {
            _context.Update(measurementUnit);
            _context.SaveChanges();
            return measurementUnit;
        }

        public bool MeasurementUnitExists(int id)
        {
            return _context.MeasurementUnits.Any(e => e.Id == id);

        }
    }
}
