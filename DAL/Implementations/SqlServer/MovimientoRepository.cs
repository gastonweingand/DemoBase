using DAL.Contracts;
using DomainModel.DomainParcial;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.SqlServer
{
    internal class MovimientoRepository : Repository, IGenericRepository<Movimiento>
    {
        public MovimientoRepository(SqlConnection context, SqlTransaction _transaction)
            : base(context, _transaction)
        {

        }
        public void Add(Movimiento obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movimiento> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Movimiento SelectOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Movimiento obj)
        {
            throw new NotImplementedException();
        }
    }
}
