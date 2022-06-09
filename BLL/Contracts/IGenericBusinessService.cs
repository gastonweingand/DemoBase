using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    internal interface IGenericBusinessService <T>
    {
        void Add(T obj);

        void Update(T obj);

        void Delete(Guid id);

        IEnumerable<T> SelectAll();

        T SelectOne(Guid id);

    }
}
