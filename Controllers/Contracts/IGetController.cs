using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Contracts
{
    interface IGetController<T>
    {
        T Get(Guid id);

        IEnumerable<T> GetAll();
    }
}
