﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Domain.Factory
{
    public interface IContainer
    {
        T Resolve<T>();
    }
}
