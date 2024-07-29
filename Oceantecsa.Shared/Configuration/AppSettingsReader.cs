using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Shared.Configuration
{
    public static class AppSettingsReader
    {
        public static IConfigurationRoot ReadConfigurationFromAppSettings()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            ////configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();
            return root;
        }

    }
}
