using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contracts;
using DomainModel.DomainParcial;

namespace DAL.Implementations.SqlServer
{
    internal class AlmacenRepository : Repository, IGenericRepository<Almacen>
    {
        public AlmacenRepository(SqlConnection context, SqlTransaction _transaction)
            : base(context, _transaction)
        {

        }
        public void Add(Almacen obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Almacen> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Almacen SelectOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Almacen obj)
        {
            throw new NotImplementedException();
        }
    }
}
