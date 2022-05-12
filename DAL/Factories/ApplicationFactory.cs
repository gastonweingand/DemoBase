using DAL.Contracts;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factories
{
    public static class ApplicationFactory
    {
        private static string backendDS = ConfigurationManager.AppSettings["BackendDS"];

        public static IGenericRepository<Customer> CustomerRepository { get; private set; }

        static ApplicationFactory()
        {
            if (backendDS == "sqlserver")
            {
                CustomerRepository = new DAL.Implementations.SqlServer.CustomerRepository();
            }
            else if (backendDS == "plaintext")
            {
                CustomerRepository = new DAL.Implementations.PlainText.CustomerRepository();
            }
        }
    }
}
