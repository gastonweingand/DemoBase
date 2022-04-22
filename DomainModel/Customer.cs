using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Customer
    {
        public Customer()
        {
            this.IdCustomer = Guid.NewGuid();
        }
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public DateTime DateBirth { get; set; }

        public String Doc { get; set; }

        public Guid IdCustomer { get; set; }
    }
}
