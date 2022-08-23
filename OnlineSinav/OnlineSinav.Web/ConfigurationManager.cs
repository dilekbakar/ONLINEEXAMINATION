using Microsoft.Extensions.Configuration;
using System.IO;

namespace OnlineSinav.Web
{
    public static class ConfigurationManager
    {
        public static IConfiguration configuration = null;
        static ConfigurationManager()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
        }
        public static string GetFilePath()
        {
            return configuration["CustomKeys:BaseUrl"] + "file/";
        }
    }
}
