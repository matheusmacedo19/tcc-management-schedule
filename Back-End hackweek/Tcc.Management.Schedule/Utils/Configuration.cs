using System.Xml.Linq;

namespace Tcc.Management.Schedule.Utils
{
    public class Configuration
    {
        public static string GetConnectionString(string name)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configuration = builder.Build();
            return configuration.GetConnectionString(name);
        }
    }
}
