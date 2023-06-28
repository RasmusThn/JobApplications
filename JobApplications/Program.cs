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
            string applicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string usersFolderPath = Path.Combine(applicationDirectory, "Users");

            // Create the directory if it doesn't exist
            if (!Directory.Exists(usersFolderPath))
            {
                Directory.CreateDirectory(usersFolderPath);
            }


            // Configure DI container
            var serviceProvider = new ServiceCollection()
                .AddTransient<IFilePathProvider>(provider => new FilePathProvider(usersFolderPath))
                .AddTransient<UserDataAccess>()
                .AddTransient<JobDataAccess>()
                .AddTransient<UserLoginForm>(provider =>
                {
                    var filePathProvider = provider.GetRequiredService<IFilePathProvider>();
                    return new UserLoginForm(filePathProvider);
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