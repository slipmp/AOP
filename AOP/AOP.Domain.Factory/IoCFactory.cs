﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Domain.Factory
{
    public class IoCFactory
    {
        public List<IContainer> GetContainerList()
        {
            var containerList = new List<IContainer>();

            containerList.Add(new CastleWindsorIoCContainer());
            containerList.Add(new UnityIoCContainer());
            containerList.Add(new NinjectIoCContainer());

            return containerList;
        }
    }
}
