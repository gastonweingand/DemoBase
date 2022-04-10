using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Customer
    {
        public String Name { get; set; }

        public String SurName { get; set; }

        public DateTime BirthDate { get; set; }

        public String DNI { get; set; }

        public Guid IdCustomer { get; set; }
    }
}
