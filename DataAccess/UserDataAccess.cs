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
          
            // Serialize the User object to JSON
            string json = JsonSerializer.Serialize(user);

            // Write the JSON to the user-specific file
            File.WriteAllText(userFilePath, json);
        }

        public User GetUserByName(string name)
        {
            string userFilePath = CombineFilePath(name);

            if (!File.Exists(userFilePath)) 
            {
                throw new FileNotFoundException($"User file with the name '{userFilePath}' does not exist.");
            }

            string json = File.ReadAllText(userFilePath);

            // Deserialize the JSON to a List<User> object
            User? user = JsonSerializer.Deserialize<User>(json);

            return user; 
        }
        public void UpdateUser(User updatedUser)
        {
            string userFilePath = CombineFilePath(updatedUser.Name);

            // Check if the user-specific file exists
            if (!File.Exists(userFilePath))
            {
                // Handle the case where the user-specific file does not exist
                // For example, you can throw an exception, log a message, or handle it in any other way you prefer
                throw new FileNotFoundException($"User file with the name '{userFilePath}' does not exist.");
            }

            // Serialize the updated User object to JSON
            string json = JsonSerializer.Serialize(updatedUser);

            // Write the JSON to the user-specific file, overwriting the existing data
            File.WriteAllText(userFilePath, json);
        }
    }
}
