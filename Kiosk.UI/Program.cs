using System;
using System.Windows.Forms;
using Kiosk.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using MediatR;
using Kiosk.Core.Repositories.IRepositories;
using Kiosk.Data.Models;
using Kiosk.Data.Repositories;
namespace Kiosk.UI
{
    internal static class Program
    {
        private static ServiceProvider serviceProvider;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Set up Dependency Injection
            serviceProvider = ConfigureServices();

            AddTestUser();

            // Run the main form (AdminView)
            Application.Run(serviceProvider.GetRequiredService<Views.AdminView>());
        }

        private static IConfiguration LoadConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Load configuration
            var configuration = LoadConfiguration();

            // Register DbContext with Migrations Assembly
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("Kiosk.Data")));

            // Register Forms
            services.AddTransient<Views.AdminView>();

            // Register Repositories
            services.AddScoped<IBaseRepository<User>, UsersRepository>();

            return services.BuildServiceProvider();
        }

        private static void AddTestUser()
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var userRepository = scope.ServiceProvider.GetRequiredService<IBaseRepository<User>>();

                var newUser = new User
                {
                    Name = "Test User",
                    Username = "testuser",
                    PasswordHash = "hashedpassword",
                    ContactNumber = "1234567890",
                    Email = "testuser@example.com",
                    Role = "Admin",
                    Address = "123 Test Street",
                    CreatedAt = DateTime.Now
                };

                var result = userRepository.AddAsync(newUser).Result;

                if (result != null)
                {
                    MessageBox.Show("User added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add user.");
                }
            }
        }
    }
}
