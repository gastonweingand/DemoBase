using DAL.Contracts;
using DomainModel.DomainParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.Memory
{
    public class ProductoRepository : IGenericRepository<Producto>
    {
        public void Add(Producto obj)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Update(Producto obj)
        {
            throw new NotImplementedException();
        }
    }
}
