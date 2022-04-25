using DAL.Contracts;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.SqlServer.Adapter
{

    internal sealed class CustomerAdapter : IAdapter<Customer>
    {
        #region Singleton
        private readonly static CustomerAdapter _instance = new CustomerAdapter();

        public static CustomerAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private CustomerAdapter()
        {
        }

        #endregion

        public Customer Adapt(object[] values)
        {
            //Hidratar el objeto customer
            Customer customer = new Customer()
            {
                IdCustomer = Guid.Parse(values[0].ToString()),
                FirstName = values[1].ToString(),
                LastName = values[2].ToString(),
                DateBirth = DateTime.Parse(values[3].ToString()),
                Doc = values[4].ToString()
            };
            return customer;
        }
        //Implement here the initialization code
    }
}