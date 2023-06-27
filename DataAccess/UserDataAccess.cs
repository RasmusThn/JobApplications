using Entitys;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceContracts.Interfaces;
using System.Xml.Linq;

namespace DataAccess
{
    public class UserDataAccess
    {
        private readonly string connectionString;

        public UserDataAccess(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionString = connectionStringProvider.GetConnectionString();
        }
        public void SomeMethod()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Execute your database operations using SqlCommand, SqlDataAdapter, etc.
                // For example:
                string sql = "SELECT * FROM Users";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read data from the reader
                            // For example:
                            int userId = (int)reader["Id"];
                            string userName = (string)reader["Name"];

                            // Do something with the data
                            // For example:
                            Console.WriteLine($"User ID: {userId}, Name: {userName}");
                        }
                    }
                }

                // Close the connection
                connection.Close();
            }
        }
        public void InsertUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Name) VALUES (@Name)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", user.Name);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public User GetUserByName(string name)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Name = @Name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User user = new User();
                        user.Id = (int)reader["Id"];
                        user.Name = (string)reader["Name"];

                        // You can also load related data such as Jobs if needed
                        // For example:
                        user.Jobs = GetJobsByUserId(user.Id);

                        return user;
                    }
                }
            }

            return null; // User not found
        }
        public List<Job> GetJobsByUserId(int userId)
        {
            List<Job> jobs = new List<Job>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Jobs WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Job job = new Job
                    {
                        Id = (int)reader["Id"],
                        CompanyName = (string)reader["CompanyName"],
                        JobType = (string)reader["JobType"],
                        Location = (string)reader["Location"],
                        ApplyDate = (DateTime)reader["ApplyDate"],
                        ResponseDate = (DateTime)reader["ResponseDate"],
                        IsAccepted = (bool)reader["IsAccepted"]
                    };

                    jobs.Add(job);
                }

                reader.Close();
            }

            return jobs;
        }
    }
}
