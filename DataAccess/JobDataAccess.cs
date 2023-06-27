using Entitys;
using ServiceContracts.Interfaces;
using System.Data.SqlClient;

namespace DataAccess
{
    public class JobDataAccess
    {
        private readonly string connectionString;

        public JobDataAccess(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionString = connectionStringProvider.GetConnectionString();
        }

        public void CreateJobForUserWithId(Job job, int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Jobs (CompanyName, JobType, Location, ApplyDate, ResponseDate, IsAccepted, UserId)
                         VALUES (@CompanyName, @JobType, @Location, @ApplyDate, @ResponseDate, @IsAccepted, @UserId)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CompanyName", job.CompanyName);
                command.Parameters.AddWithValue("@JobType", job.JobType);
                command.Parameters.AddWithValue("@Location", job.Location);
                command.Parameters.AddWithValue("@ApplyDate", job.ApplyDate);
                command.Parameters.AddWithValue("@ResponseDate", job.ResponseDate);
                command.Parameters.AddWithValue("@IsAccepted", job.IsAccepted);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}