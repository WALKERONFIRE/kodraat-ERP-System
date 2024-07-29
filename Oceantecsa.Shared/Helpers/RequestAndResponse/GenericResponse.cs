using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.Helpers.RequestAndResponse
{
    public class GenericResponse<T> : GlobalResponse
    {
        public new T Data { get; set; }
    }
}
