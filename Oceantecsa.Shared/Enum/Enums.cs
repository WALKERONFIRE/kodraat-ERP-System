using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.Enum
{
    public class Enums
    {
    }
    [Flags]
    public enum Language
    {
        En = 0,
        Ar = 1
    }

    public enum ErrorMessages
    {
        Failed = 5001,
        UnAuth = 5002,
        Error_Updating = 5003,
        Error_Saving = 5004,
        Password_Miss_match = 5005,
        Error_Deleting_Data = 5006,
        Invalid_Data = 5007,
        Error_Posting_SalesOrder = 5008,
        Ivalid_file_Attachment = 5009,
        Invalid_Login = 5010,
        ErrorUpdateReceiveOrder = 5011,
        Erorr_in_prices = 5012,
        Error_Prepaid = 5013,
        Error_NotFound_Order = 5014,
        Erorr_posted_Befor = 5015,
        Error_notRequestedSizeUPdate = 5016,
        Error_UpdateReceiveOrder = 5020,
        Incorrect_vat = 5021,
        Incorrect_TotalPrice = 5022,
        Invalide_NetValue = 5023,
        Incorrect_Discount = 5024,
        Error_AddReceiveOrder = 5030,
        Cant_Export_File = 5031,
        ZeroQuantitiy = 5032,
        CashInvoiceTypeError = 5033,
        Error_Posting = 5034,
        Error_While_Getting_Data = 5035,
        Not_Enough_Balance = 5036,
        Error_In_Sizes = 5037
    }
}
