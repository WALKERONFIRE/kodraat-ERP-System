using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oceantecsa.Domain.Models;
using Oceantecsa.Shared.DTOs;
using Oceantecsa.Shared.Enum;
using Oceantecsa.Shared.Helpers;
using Oceantecsa.Shared.Helpers.RequestAndResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using IdentityServer3;
using System.Text;
using System.Threading.Tasks;
using Oceantecsa.Shared.ActionFilter;

namespace Oceantecsa.Shared.BaseController
{
    [TokenValidator]
    [SetLanguage]
    [ApiController]
    public class OceanTecsaController: ControllerBase
    {

        protected Language Language
        {
            get
            {
                var LanguageCode = Request.Headers.TryGetValue("Language", out var languageCode).ToString();
                var lang = languageCode.FirstOrDefault().ToUpper();
                GlobalParam.IsArabic = lang == "AR";
                return lang == "AR" ? Language.Ar : Language.En;
            }
        }

        protected OkObjectResult Success()
        {
            var result = new GlobalResponse().SuccessResult();
            return new OkObjectResult(result);
        }

        protected OkObjectResult Success(object data, int successMessageId = 0)
        {
            string successMessage = null;
            if (successMessageId > 0)
            {
                var localizedMessages = OceanTecsaMessagesHelper.GetSuccessMessageById(successMessageId) ??
                                        new List<string> { successMessageId.ToString() };
                successMessage = Language == Language.En ? localizedMessages[0] : localizedMessages[1];
            }

            var result = new GlobalResponse().SuccessResult(data, successMessage);
            return new OkObjectResult(result);
        }

        protected ErrorObjectResult Error(int errorMessageId, int statusCode, params object[] messagArgs)
        {
            var errorMessages = OceanTecsaMessagesHelper.GetErrorMessageById(errorMessageId) ?? new List<string>
            {
                string.Format(Constants.Default_Error_MessageEn , errorMessageId),
                string.Format(Constants.Default_Error_MessageAr , errorMessageId)
            };
            var result = new GlobalResponse().ErrorResult(Language == Language.En ? String.Format(errorMessages[0], messagArgs) : String.Format(errorMessages[1], messagArgs), errorCode: errorMessageId,
                statusCode);

            return new ErrorObjectResult(statusCode, result);
        }
        protected ErrorObjectResult Error(ErrorMessages errorMessageId, int statusCode, params object[] messagArgs)
        {

            var errorMessages = OceanTecsaMessagesHelper.GetErrorMessageById((int)errorMessageId) ?? new List<string>
            {
                "Server returns not mapped error code  " + (int)errorMessageId,
                "الخادم يرسل رمز خطأ غير معروف  " + (int)errorMessageId
            };
            var result = new GlobalResponse().ErrorResult(Language == Language.En ? String.Format(errorMessages[0], messagArgs) : String.Format(errorMessages[1], messagArgs), errorCode: (int)errorMessageId, statusCode);

            return new ErrorObjectResult(statusCode, result);
        }
        protected ErrorObjectResult Error(int statusCode, string errorMessageEn = "Server returns not mapped error", string errorMessageAr = "الخادم يرسل رمز خطأ غير معروف", params object[] messagArgs)
        {

            var errorMessages = new List<string>
            {
                errorMessageEn,
                errorMessageAr
            };

            var result = new GlobalResponse().ErrorResult(Language == Language.En ? String.Format(errorMessages[0], messagArgs) : String.Format(errorMessages[1], messagArgs), errorCode: 5001, statusCode);

            return new ErrorObjectResult(statusCode, result);
        }
        protected ErrorObjectResult Error(BusinessException businessException, int statusCode)
        {
            if (businessException.ErrorMessageEnum.HasValue)
            {
                return Error(businessException.ErrorMessageEnum.Value, statusCode, businessException.MessageArgs);
            }
            else
            {
                return Error(400, businessException.MessageEnglish, businessException.MessageArabic, businessException.MessageArgs);
            }

        }

        [NonAction]
        protected IActionResult Unauthorized(object data, string successMessage = null)
        {
            return Ok(new GlobalResponse().UnauthorizedResult(data));
        }

        [NonAction]
        public int GetUserId()
        {
            var user = ClaimsHelper.GetUserFromClaims(User.Identity as ClaimsIdentity);
            int UserId = Convert.ToInt32(user.UserId);
            return UserId;
        }
        [NonAction]
        public UserInfoDTO GetUserData()
        {
            try
            {
                var user = ClaimsHelper.GetUserFromClaims(User.Identity as ClaimsIdentity);
                var userInfo = JsonConvert.DeserializeObject<UserInfoDTO>(user.UserInfo);
                return userInfo;
            }
            catch (Exception)
            {
                throw new BusinessException(StatusCodes.Status401Unauthorized, ErrorMessages.Invalid_Login);
            }

        }
    }
}
