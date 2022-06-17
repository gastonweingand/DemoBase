using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controllers.Contracts
{
    internal interface ICRUDController<T> : IUpdateController<T>, ICreateController<T>, IGetController<T>, IRemoveController<T>
    {
    }
}
