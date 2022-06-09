using DomainModel;
using DomainModel.DomainParcial;

namespace DAL.Contracts.UnitOfWork
{
    public interface IUnitOfWorkRepository
    {
        IGenericRepository<Customer> CustomerRepository { get; }

        IGenericRepository<Almacen> AlmacenRepository { get; }

        IGenericRepository<Movimiento> MovimientoRepository { get; }

        IGenericRepository<Producto> ProductoRepository { get; }
    }
}
