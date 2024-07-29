using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IShippingTypeService//ShippingType
    {
        IEnumerable<ShippingType> GetAllShippingType();
        ShippingType GetShippingType(int id);
        void AddShippingType(ShippingTypeDTO  shippingType);
        void EditShippingType(int id, ShippingTypeDTO  shippingType);
        void DeleteShippingType(int id);

    }
}
