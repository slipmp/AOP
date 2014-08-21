using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.Core;
using AOP.Domain.Implementation;
using AOP.Domain.Interface;
using Castle.MicroKernel.Registration;
using Castle.DynamicProxy;
using AOP.Domain.Interceptor;
using Microsoft.Practices.Unity;

namespace AOP.Domain.Factory
{
    public class UnityIoCContainer : IContainer
    {
        public T Resolve<T>()
        {
            var container = new UnityContainer();

            container.RegisterType<IPressReleaseService, PressReleaseService>();

            return container.Resolve<T>();
        }
    }
}
