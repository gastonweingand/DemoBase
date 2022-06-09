using DAL.Contracts;
using DAL.Contracts.UnitOfWork;
using DomainModel;
using DomainModel.DomainParcial;
using System.Data.SqlClient;

namespace DAL.Implementations.SqlServer.UnitOfWork
{
    public class UnitOfWorkSqlServerRepository : IUnitOfWorkRepository
    {
        public IGenericRepository<Customer> CustomerRepository { get; }

        public IGenericRepository<Almacen> AlmacenRepository { get; }

        public IGenericRepository<Movimiento> MovimientoRepository { get; }

        public IGenericRepository<Producto> ProductoRepository { get; }

        public UnitOfWorkSqlServerRepository(SqlConnection context, SqlTransaction transaction)
        {
            CustomerRepository = new CustomerRepository();

            AlmacenRepository = new AlmacenRepository(context, transaction);

            MovimientoRepository = new MovimientoRepository(context, transaction);    
            
            ProductoRepository = new ProductoRepository(context, transaction);
        }
    }
}

