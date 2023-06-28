using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceContracts.Interfaces;

namespace Services
{
    public class FilePathProvider : IFilePathProvider
    {
        private readonly string _filePath;

        public FilePathProvider(string filePath)
        {
            this._filePath = filePath;
        }

        public string GetFilePath()
        {
            return _filePath;
        }
    }

}
