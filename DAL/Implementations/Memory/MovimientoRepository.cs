using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contracts;
using DomainModel.DomainParcial;

namespace DAL.Implementations.Memory
{
    public class MovimientoRepository : IGenericRepository<Movimiento>
    {
        List<Movimiento> listadoMovimientos = new List<Movimiento>();

        public void Add(Movimiento obj)
        {
            listadoMovimientos.Add(obj);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movimiento> SelectAll()
        {
            return listadoMovimientos;
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
