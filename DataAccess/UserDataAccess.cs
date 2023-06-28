using Entitys;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceContracts.Interfaces;
using System.Xml.Linq;
using System.Text.Json;

namespace DataAccess
{
    public class UserDataAccess
    {
        private readonly string filePath;

        public UserDataAccess(IFilePathProvider filePathProvider)
        {
            this.filePath = filePathProvider.GetFilePath();
        }

        public void InsertUser(User user)
        {
            // Create a unique filename for the user
            string fileName = $"{user.Name}.json";
            string userFilePath = Path.Combine(filePath, fileName);

            // Check if a file with the same name already exists
            if (File.Exists(userFilePath))
            {
                // Handle the case where a file with the same name already exists
                // For example, you can throw an exception, log a message, or handle it in any other way you prefer
                throw new InvalidOperationException($"A user file with the name '{fileName}' already exists.");
            }

            // Create the user-specific file
            using (File.Create(userFilePath)) { }

            // Serialize the User object to JSON
            string json = JsonSerializer.Serialize(user);

            // Write the JSON to the user-specific file
            File.WriteAllText(userFilePath, json);
        }

        public User GetUserByName(string name)
        {
            // Read the JSON from the file
            string json = File.ReadAllText(filePath);

            // Deserialize the JSON to a List<User> object
            List<User> users = JsonSerializer.Deserialize<List<User>>(json);

            // Find the user with the matching name
            User user = users.FirstOrDefault(u => u.Name == name);

            if (user != null)
            {
                // You can also load related data such as Jobs if needed
                // For example:
                user.Jobs = GetJobsByUserId(user.Id);

                return user;
            }

            return null; // User not found
        }
        public List<Job> GetJobsByUserId(int userId)
        {
            // Read the JSON from the file
            string json = File.ReadAllText(filePath);

            // Deserialize the JSON back to a List<Job> object
            List<Job> jobs = JsonSerializer.Deserialize<List<Job>>(json);

            // Filter the jobs based on the UserId
            List<Job> filteredJobs = jobs.FindAll(job => job.UserId == userId);

            return filteredJobs;
        }
    }
}
