using DAL.Contracts;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.PlainText
{
    public class CustomerRepository : IGenericRepository<Customer>
    {
        public void Add(Customer obj)
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
            Console.WriteLine("Llamando al selectOne de PlainText");
            return null;
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
