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

        private IFilePathProvider _filePathProvider;
        private UserDataAccess _dataAccess;
        private User _user;

        public UserService(IFilePathProvider filePathProvider)
        {
            _filePathProvider = filePathProvider;
            _dataAccess = new UserDataAccess(_filePathProvider);
        }


        public void CreateUser(User user)
        {
            user.Jobs = new List<Job>();
            _dataAccess.InsertUser(user);
               
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
        public void UpdateUser(User user)
        {
            _dataAccess.UpdateUser(user);
        }

        public bool DoesUserExist(string username)
        {
            throw new NotImplementedException();
        }
    }
}
