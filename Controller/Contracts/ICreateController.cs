﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Contracts
{
    internal interface ICreateController<T>
    {
        void Add(T obj);
    }
}
