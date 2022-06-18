using DAL.Contracts;
using DAL.Implementations.SqlServer.Adapter;
using DomainModel.DomainParcial;
using Services.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.SqlServer
{
    internal class ProductoRepository : Repository, IGenericRepository<Producto>
    {

        public ProductoRepository(SqlConnection context, SqlTransaction _transaction)
            : base(context, _transaction)
        {

        }
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Producto] (Id, Codigo, Descripcion, Precio) VALUES (@Id, @Codigo, @Descripcion, @Precio)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Producto] SET (Codigo, Descripcion, Precio) WHERE Id = @Id";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Producto] WHERE Id = @Id";
        }

        private string SelectOneStatement
        {
            get => "SELECT Id, Codigo, Descripcion, Precio FROM [dbo].[Producto] WHERE Id = @Id";
        }

        private string SelectAllStatement
        {
            get => "SELECT Id, Codigo, Descripcion, Precio FROM [dbo].[Producto]";
        }
        #endregion


        public void Add(Producto obj)
        {
            try
            {
                //Verificar porque solo funciona con SP -> https://stackoverflow.com/questions/2041013/sql-server-return-uniqueidentifier-from-stored-procedure

                //obj.Id = Guid.Parse(ExecuteScalar(InsertStatement, System.Data.CommandType.Text, new SqlParameter[] {
                //                    new SqlParameter("@Codigo", obj.Codigo),
                //                    new SqlParameter("@Descripcion", obj.Descripcion),
                //                    new SqlParameter("@Precio", obj.Precio)
                //              }).ToString());

                ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, new SqlParameter[] {
                                    new SqlParameter("@Codigo", obj.Codigo),
                                    new SqlParameter("@Descripcion", obj.Descripcion),
                                    new SqlParameter("@Precio", obj.Precio),
                                    new SqlParameter("@Id", Guid.NewGuid()) });
            }
            catch (Exception ex)
            {
                ex.Handle(this);
            }
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> SelectAll()
        {
            List<Producto> productos = new List<Producto>();

            using (var readerProducto = ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
            {
                Object[] values = new Object[readerProducto.FieldCount];

                while (readerProducto.Read())
                {
                    readerProducto.GetValues(values);
                    productos.Add(ProductoAdapter.Current.Adapt(values));
                }
            }

            return productos;
        }

        public Producto SelectOne(Guid id)
        {
            Producto productoGet = null;

            using (var readerProducto = ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                        new SqlParameter[] { new SqlParameter("@Id", id) }))
            {
                object[] values = new object[readerProducto.FieldCount];

                if (readerProducto.Read())
                {
                    readerProducto.GetValues(values);
                    productoGet = ProductoAdapter.Current.Adapt(values);
                }
                return productoGet;
            }
        }
        public IEnumerable<Producto> SelectALl(string sFilterExpression)
        {
            string sqlStatement = sFilterExpression ?? SelectAllStatement;

            sqlStatement = (sqlStatement == sFilterExpression) ? SelectAllStatement +
                            " where " + sFilterExpression : sqlStatement;

            var readerProducto = ExecuteReader(SelectOneStatement, System.Data.CommandType.Text);

            Object[] values = new Object[readerProducto.FieldCount];

            while (readerProducto.Read())
            {
                readerProducto.GetValues(values);
                yield return ProductoAdapter.Current.Adapt(values);
            }
        }

        public void Update(Producto obj)
        {
            throw new NotImplementedException();
        }
    }
}
