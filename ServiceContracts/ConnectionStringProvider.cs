using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceContracts.Interfaces;

namespace Services
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        private readonly string connectionString;

        public ConnectionStringProvider(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string GetConnectionString()
        {
            return connectionString;
        }
    }

}
