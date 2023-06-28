using Entitys;
using ServiceContracts.Interfaces;
using System.Data.SqlClient;
using System.Text.Json;

namespace DataAccess
{
    public class JobDataAccess
    {
        private readonly string _filePath;

        public JobDataAccess(IFilePathProvider filePathProvider)
        {
            this._filePath = filePathProvider.GetFilePath();
        }

        public void CreateJobForUserWithName(Job job, string name)
        {
            // Retrieve the file path
            string fileName = $"{name}.json";
            string userFilePath = Path.Combine(_filePath, fileName);

            // Read the JSON from the file
            string json = File.ReadAllText(userFilePath);

            // Deserialize the JSON back to a User object
            User user = JsonSerializer.Deserialize<User>(json);

            // Find the user with the given userId
            if (user != null && user.Name == name)
            {
                if(user.Jobs.Count > 0) 
                {
                int maxJobId = user.Jobs.Max(x => x.Id);
                job.Id = maxJobId + 1;
                
                }
                else
                {
                    job.Id = 1;
                }
                // Increment the jobId by 1 for the new job
                // Add the job to the user's jobs list
                user.Jobs.Add(job);

                // Serialize the User object back to JSON
                string updatedJson = JsonSerializer.Serialize(user);

                // Write the updated JSON back to the file
                File.WriteAllText(userFilePath, updatedJson);
            }
        }
    }
}