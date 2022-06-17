using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Contracts
{
    internal interface IRemoveController<T>
    {
        void Remove(Guid id);
    }
}
