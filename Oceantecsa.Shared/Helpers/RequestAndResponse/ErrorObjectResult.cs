using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.Helpers.RequestAndResponse
{
    public class ErrorObjectResult : ObjectResult
    {
        public ErrorObjectResult(int statusCode, object error) : base(error)
        {
            this.StatusCode = statusCode;
        }
    }
}
