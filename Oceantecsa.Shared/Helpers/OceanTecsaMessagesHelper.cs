using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Oceantecsa.Shared.Configuration;
using Oceantecsa.Shared.DTOs;
using Oceantecsa.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.Helpers
{

    public static class OceanTecsaMessagesHelper
    {
        private static Root GetAllSuccessMessages()
        {
            IConfigurationRoot root = AppSettingsReader.ReadConfigurationFromAppSettings();
            var filePath = root["Messages:JsonSuccessMessagesPath"];
            string json = SharedMethods.GetFileContent(filePath);
            return JsonConvert.DeserializeObject<Root>(json);

        }
        private static Root GetAllErrorMessages()
        {
            IConfigurationRoot root = AppSettingsReader.ReadConfigurationFromAppSettings();
            var filePath = root["Messages:JsonErrorMessagesPath"];
            string json = SharedMethods.GetFileContent(filePath);
            return JsonConvert.DeserializeObject<Root>(json);

        }
        public static List<string> GetSuccessMessageById(int messageId)
        {
            var currentError = GetAllSuccessMessages().Messages.FirstOrDefault(m => m.Id == messageId);
            return currentError == null ? null : new List<string> { currentError.DescriptionEN, currentError.DescriptionAR };
        }
        public static List<string> GetErrorMessageById(int messageId)
        {
            var currentError = GetAllErrorMessages().Messages.FirstOrDefault(m => m.Id == messageId);
            return currentError == null ? null : new List<string> { currentError.DescriptionEN, currentError.DescriptionAR };
        }
    }
    public class Root
    {
        public List<Message> Messages { get; set; }
    }
}
