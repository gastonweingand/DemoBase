using DAL.Contracts;
using DAL.Implementations.SqlServer.Adapter;
using DAL.Tools;
using DomainModel;
using Services.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;

namespace DAL.Implementations.SqlServer
{
    internal class CustomerRepository : IGenericRepository<Customer>
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
            get => "SELECT [IdCustomer] ,[FirstName],[LastName] ,[DateBirth] ,[Doc] ,[IdAddress] FROM [dbo].[Customer] WHERE IdCustomer = @IdCustomer";
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
            string word = "Gonzalo".Translate();

            throw new NotImplementedException();
        }

        public IEnumerable<Customer> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Customer SelectOne(Guid id)
        {
            //Services.Services.LoggerService.WriteLog("Guardando un customer", EventLevel.Informational, "sin usuario");
            Customer customerGet = null;

            try
            {
                using (var reader = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                                new SqlParameter[] { new SqlParameter("@IdCustomer", id) }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        customerGet = CustomerAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle(this);
            }

            return customerGet;
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
