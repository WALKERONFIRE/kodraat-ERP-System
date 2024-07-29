using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.ActionFilter
{
    public class SetLanguageAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var header = context.HttpContext.Request.Headers;

            if (header["Language"].Count > 0)
            {
                GlobalParam.IsArabic = header["Language"].ToString().ToUpper() == "AR";
            }
            base.OnActionExecuting(context);
        }
    }
}
