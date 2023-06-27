using DataAccess;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using ServiceContracts.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Services;

namespace JobApplications
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set up configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Retrieve the connection string from appsettings.json
            var connectionString = configuration.GetConnectionString("MyConnectionString");

            // Configure DI container
            var serviceProvider = new ServiceCollection()
            .AddTransient<IConnectionStringProvider>(provider => new ConnectionStringProvider(connectionString))
            .AddTransient<UserDataAccess>()
            .AddTransient<JobDataAccess>()
            .AddTransient<UserLoginForm>(provider =>
            {
                var connectionStringProvider = provider.GetRequiredService<IConnectionStringProvider>();
                return new UserLoginForm(connectionStringProvider);
            })
            .BuildServiceProvider();


            ApplicationConfiguration.Initialize();

            // Resolve the MainForm instance from the DI container
            var mainForm = serviceProvider.GetRequiredService<UserLoginForm>();

            // Start the application with the MainForm instance
            Application.Run(mainForm);
        }
    }


}