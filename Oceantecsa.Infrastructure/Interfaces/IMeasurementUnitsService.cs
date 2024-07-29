using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IMeasurementUnitsService
    {
        Task<IEnumerable<MeasurementUnit>> GetAll();

        Task<MeasurementUnit> GetById(int id);

        Task<MeasurementUnit> Add(MeasurementUnit measurementUnit);
        MeasurementUnit Update(MeasurementUnit measurementUnit);
        MeasurementUnit Delete(MeasurementUnit measurementUnit);

        bool MeasurementUnitExists(int id);
    }
}
