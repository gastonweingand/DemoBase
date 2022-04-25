using BLL.Contracts;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contracts;
using DAL.Factories;
using BLL.BusinessExceptions;

namespace BLL.Services
{

    public sealed class CustomerService : IGenericBusinessService<Customer>
    {
        #region Singleton
        private readonly static CustomerService  _instance = new CustomerService ();

        public static CustomerService  Current
        {
            get
            {
                return _instance;
            }
        }

        private CustomerService()
        {
            //Implement here the initialization code
        }

        #endregion

        public void Add(Customer obj)
        {
            //IGenericRepository<Customer> repo = CustomerFactory.Current.GetFactory("sqlserver");

            //Para poder dar de alta un nuevo cliente, el mismo deberá ser mayor de edad...

            //Valido si es mejor de edad
            if (obj.DateBirth > DateTime.Now.AddYears(-18))
                throw new ClienteMayorEdadException();

            CustomerFactory.Current.GetFactory("sqlserver").Add(obj);

        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Customer SelectOne(Guid id)
        {
            throw new NotImplementedException();
        }

    }

}
