using DAL.Contracts;
using DAL.Tools;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.SqlServer
{
    public class CustomerRepository : IGenericRepository<Customer>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Customer] (IdCustomer, Name, SurName, BirthDate, DNI) VALUES (@IdCustomer, @Name, @SurName, @BirthDate, @DNI)";
        }

        private string UpdateStatement  
        {
            get => "UPDATE [dbo].[Customer] SET (Name = @Name, SurName = @SurName, BirthDate = @BirthDate, DNI = @DNI) WHERE IdCustomer = @IdCustomer";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Customer] WHERE IdCustomer = @IdCustomer";
        }

        private string SelectOneStatement
        {
            get => "SELECT IdCustomer, Name, SurName, BirthDate, DNI FROM [dbo].[Customer] WHERE IdCustomer = @IdCustomer";
        }

        private string SelectAllStatement
        {
            get => "SELECT IdCustomer, Name, SurName, BirthDate, DNI FROM [dbo].[Customer]";
        }
        #endregion

        public void Add(Customer obj)
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@IdCustomer", obj.IdCustomer);
            SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, parameters);
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
            Console.WriteLine("Llamando al selectOne de SqlServer");
            return null;
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
