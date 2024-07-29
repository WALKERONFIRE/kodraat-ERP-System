using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.Helpers.RequestAndResponse
{
    public class GlobalResponse : ActionResult, IActionResult
    {
        public GlobalResponse()
        {
            IsSuccess = false;
        }
        public GlobalResponse(ActionContext context)
        {
            ErrorMessage = "The inputs supplied to the API are invalid";
            IsSuccess = false;
            StatusCode = 400;
            Data = ConstructErrorMessages(context);
        }
        public bool? IsSuccess { get; set; }
        public string SuccessMessage { get; set; }
        public object Data { get; set; }
        public string ErrorMessage { get; set; }
        public int StatusCode { get; set; }
        public int ErrorCode { get; set; }
        public GlobalResponse SuccessResult()
        {
            var result = new GlobalResponse { IsSuccess = true, Data = null, StatusCode = (int)HttpStatusCode.OK };
            return result;
        }

        public GlobalResponse UnauthorizedResult(object data)
        {
            return new GlobalResponse { IsSuccess = false, Data = data, StatusCode = (int)HttpStatusCode.Unauthorized, ErrorMessage = HttpStatusCode.Unauthorized.ToString() };
        }


        public GlobalResponse SuccessResult(object data, string successMessage)
        {
            var result = new GlobalResponse { IsSuccess = true, Data = data, StatusCode = (int)HttpStatusCode.OK, SuccessMessage = successMessage };
            return result;
        }

        public GlobalResponse SuccessResult(string successMessage, int statusCode)
        {
            var result = new GlobalResponse { IsSuccess = true, Data = null, StatusCode = statusCode, SuccessMessage = successMessage };
            return result;
        }
        public GlobalResponse ErrorResult(string errorMessage, int errorCode, int statusCode)
        {
            var result = new GlobalResponse { IsSuccess = false, Data = null, StatusCode = statusCode, ErrorMessage = errorMessage, ErrorCode = errorCode };
            return result;
        }
        private List<ValidationResult> ConstructErrorMessages(ActionContext context)
        {
            List<ValidationResult> result = new List<ValidationResult>();
            foreach (var keyModelStatePair in context.ModelState)
            {
                var key = keyModelStatePair.Key;
                var errors = keyModelStatePair.Value.Errors;
                var errorMessages = new string[errors.Count];
                if (errors != null && errors.Count > 0)
                {
                    for (var i = 0; i < errors.Count; i++)
                    {
                        errorMessages[i] = GetErrorMessage(errors[i]);
                    }
                }
                result.Add(new ValidationResult { Key = key, ValidationError = string.Join(" ,\n ", errorMessages) });
            };
            return result;
        }
        string GetErrorMessage(ModelError error)
        {
            return string.IsNullOrEmpty(error.ErrorMessage) ?
                "The input was not valid." :
            error.ErrorMessage;
        }
    }
}
