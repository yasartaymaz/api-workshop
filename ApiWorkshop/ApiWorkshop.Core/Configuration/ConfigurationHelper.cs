using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiWorkshop.Core.Constants;
using Microsoft.Extensions.Configuration;

namespace ApiWorkshop.Core.Configuration
{
    public static class ConfigurationHelper
    {
        public static IConfiguration GetConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile(SettingFiles.AppSettingsFile, optional: true, reloadOnChange: true);

            return builder.Build();
        }

        public static string GetDbContext(string contextName)
        {
            var settings = GetConfig();
            string connectionString = settings["ConnectionStrings:" + contextName];

            return connectionString;
        }
    }
}
