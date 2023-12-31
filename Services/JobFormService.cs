﻿using DataAccess;
using Entitys;
using ServiceContracts.Interfaces;

namespace Services
{
    public class JobFormService
    {
        private IFilePathProvider _filePathProvider;
        private JobDataAccess _dataAccess;

        public JobFormService(IFilePathProvider filePathProvider)
        {
            this._filePathProvider = filePathProvider;
            _dataAccess = new JobDataAccess(_filePathProvider);
        }

        public void CreateJobForUser(Job job,User user)
        {
            _dataAccess.CreateJobForUserWithName(job,user.Name);
        }

    }
}