using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstroApi.Controllers
{
    public class ConfigurationVariablesController
    {
        public string GetVariable(string variableName)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            // Console.WriteLine(configuration.GetConnectionString("Test"));

            Console.WriteLine();

            return configuration.GetSection(variableName).Value ?? "";
        }
    }
}
