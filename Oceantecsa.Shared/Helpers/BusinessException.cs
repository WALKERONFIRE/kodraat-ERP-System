using Oceantecsa.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.Helpers
{
    public class BusinessException : Exception
    {


        /// <summary>
        /// An arbitrary error code.
        /// </summary>
        public ErrorMessages? ErrorMessageEnum { get; set; }
        public string MessageEnglish { get; set; }
        public string MessageArabic { get; set; }
        public object[] MessageArgs { get; set; }
        public int ErrorCode { get; set; }
        public int StatusCode { get; set; }

        public BusinessException(int statusCode, ErrorMessages errorMessage, params object[] messagArgs) : base(((int)errorMessage).ToString())
        {
            ErrorMessageEnum = errorMessage;
            MessageArgs = messagArgs;
            StatusCode = statusCode;
        }
        public BusinessException(int statusCode, string messageEn, string messageAr, params object[] messagArgs) : base(messageEn)
        {
            MessageArabic = messageAr;
            MessageEnglish = messageEn;
            MessageArgs = messagArgs;
            StatusCode = statusCode;
        }

    }
}
