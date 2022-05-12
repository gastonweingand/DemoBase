using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Contracts
{
    internal interface IAdapter<T>
    {
        T Adapt(object[] values);
    }


    //interface Mapper<T, P>
    //{
    //    T ConvertToA(P obj);
    //    P ConvertToB(T obj);
    //}
}
