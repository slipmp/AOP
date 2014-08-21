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
using Microsoft.Practices.Unity.InterceptionExtension;
using Ninject;
using Ninject.Modules;

namespace AOP.Domain.Factory
{
    public class NinjectIoCContainer : IContainer
    {
        public T Resolve<T>()
        {
            var container = new StandardKernel();
            container.Bind<IPressReleaseService>().To<PressReleaseService>();

            return container.Get<T>();
        }
    }
}
