using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Kiosk.Data.Data;
namespace Kiosk.Core.Services
{
    public class ConfigurationLoader
    {
        public static IConfiguration GetConfiguration()
        {
            var basePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../Kiosk.UI"));

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Use the current directory
                .AddJsonFile("appsetting.json", optional: false, reloadOnChange: true);  // Read the appsettings.json

            return builder.Build();  // Build and return the IConfiguration object
        }

        public static IServiceProvider ConfigureServices()
        {
            var configuration = GetConfiguration();

            var serviceProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))  // Set the connection string
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
