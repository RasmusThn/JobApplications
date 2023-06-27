using DataAccess;
using Entitys;
using ServiceContracts.Interfaces;

namespace Services
{
    public class CreateFormService
    {
        private IConnectionStringProvider _connectionStringProvider;
        private JobDataAccess _dataAccess;

        public CreateFormService(IConnectionStringProvider connectionStringProvider)
        {
            this._connectionStringProvider = connectionStringProvider;
            _dataAccess = new JobDataAccess(_connectionStringProvider);
        }

        public void CreateJobForUser(Job job,User user)
        {
            _dataAccess.CreateJobForUserWithId(job,user.Id);
        }
    }
}