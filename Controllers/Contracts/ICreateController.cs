using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Contracts
{
    interface ICreateController<T>
    {
        void Add(T obj);
    }
}
