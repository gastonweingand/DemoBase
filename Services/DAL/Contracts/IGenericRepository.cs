using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Contracts
{
    internal interface IGenericRepository<T>
    {
        void Add(T obj);

        void Update(T obj);

        void Delete(Guid id);

        IEnumerable<T> SelectAll();

        T SelectOne(Guid id);

    }
}
