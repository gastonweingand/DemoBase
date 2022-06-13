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
            get => "INSERT INTO [dbo].[Producto] (Codigo, Descripcion, Precio) VALUES (@Codigo, @Descripcion, @Precio)";
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
            var execProducto = ExecuteScalar(InsertStatement, System.Data.CommandType.Text, new SqlParameter[] {
                new SqlParameter("@Codigo", obj.Codigo),
                new SqlParameter("@Descripcion", obj.Descripcion),
                new SqlParameter("@Precio", obj.Precio)
            });
            //_context.Dispose();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Producto SelectOne(Guid id)
        {

            Producto productoGet = null;

            var readerProducto = ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                        new SqlParameter[] { new SqlParameter("@Id", id) });
            object[] values = new object[readerProducto.FieldCount];

            if (readerProducto.Read())
            {
                readerProducto.GetValues(values);
                productoGet = ProductoAdapter.Current.Adapt(values);
            }
            
            //Esto no funciona. Preguntar a Gaston 2022 06 11 => _transaction.Commit();
            _context.Dispose();


            /*
             * Manera anterior. El using cierra el dr
            try
            {
                using (var reader = ExecuteReader( SelectOneStatement, System.Data.CommandType.Text,
                                        new SqlParameter[] { new SqlParameter("@Id", id) } )   )
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        customerGet = ProductoAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle(this);
            }
            */

            return productoGet;
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
            
            _context.Dispose();
        }

        public void Update(Producto obj)
        {
            throw new NotImplementedException();
        }
    }
}
