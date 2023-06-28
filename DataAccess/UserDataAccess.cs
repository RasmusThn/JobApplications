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
        private string CombineFilePath(string name)
        {
            string fileName = $"{name}.json";
            string userFilePath = Path.Combine(filePath, fileName);

            return userFilePath;
        }
        public void InsertUser(User user)
        {
            
            string userFilePath = CombineFilePath(user.Name);

            // Check if a file with the same name already exists
            if (File.Exists(userFilePath))
            {
                // Handle the case where a file with the same name already exists
                // For example, you can throw an exception, log a message, or handle it in any other way you prefer
                throw new InvalidOperationException($"A user file with the name '{userFilePath}' already exists.");
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
            string userFilePath = CombineFilePath(name);
            // Read the JSON from the file
            string json = File.ReadAllText(userFilePath);

            // Deserialize the JSON to a List<User> object
            User user = JsonSerializer.Deserialize<User>(json);

            

            //if (user.Jobs.Count > 0)
            //{
            //    // You can also load related data such as Jobs if needed
            //    // For example:
            //    user.Jobs = GetJobsByUserName(user.Name);

            //    return user;
            //}

            return user; // User not found
        }
        public List<Job> GetJobsByUserName(string userName)
        {
            string userFilePath = CombineFilePath(userName);
            // Read the JSON from the file
            string json = File.ReadAllText(userFilePath);

            // Deserialize the JSON back to a List<Job> object
            List<Job> jobs = JsonSerializer.Deserialize<List<Job>>(json);

            // Filter the jobs based on the UserId
            List<Job> filteredJobs = jobs.FindAll(job => job.UserName == userName);

            return filteredJobs;
        }
    }
}
