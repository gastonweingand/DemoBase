using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Contracts
{
    internal interface IGetController<T>
    {
        IEnumerable<T> GetAll();

        T GetById(Guid id);
    }
}
