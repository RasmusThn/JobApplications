using DataAccess;
using Entitys;
using ServiceContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService
    {

        private IConnectionStringProvider _connectionStringProvider;
        private UserDataAccess _dataAccess;
        private User _user;

        public UserService(IConnectionStringProvider connectionStringProvider)
        {
            _connectionStringProvider = connectionStringProvider;
            _dataAccess = new UserDataAccess(_connectionStringProvider);
        }


        public bool CreateUser(User user)
        {
            try
            {
            _dataAccess.InsertUser(user);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        //public bool UpdateUser(User user) { }
        //public bool DeleteUser(User user) { }
        public User GetUser(string name) 
        {
            try
            {
            _user = _dataAccess.GetUserByName(name);

                return _user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public List<Job> GetAllJobs(User user)
        {

            return user.Jobs.ToList();
        }
    }
}
