using DAL.Contracts;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factories
{

	public sealed class CustomerFactory
	{
		private readonly static CustomerFactory _instance = new CustomerFactory();

		public static CustomerFactory Current
		{
			get
			{
				return _instance;
			}
		}

		private CustomerFactory()
		{
			//Implent here the initialization of your singleton
		}

		public IGenericRepository<Customer> GetFactory(string backend)
		{ 
			if(backend == "sqlserver")
			{
				return new DAL.Implementations.SqlServer.CustomerRepository();
			}
			else if(backend == "plaintext")
			{
				return new DAL.Implementations.PlainText.CustomerRepository();
			}
			return null;
		}



	}

}
