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

namespace AOP.Domain.Factory
{
    public class UnityIoCContainer : IContainer
    {
        public T Resolve<T>()
        {
            var container = new UnityContainer();

            container.AddNewExtension<Interception>();
            container.RegisterType<IPressReleaseService, PressReleaseService>(
                new Interceptor<InterfaceInterceptor>(),
                new InterceptionBehavior<UnityInterceptor>());

            return container.Resolve<T>();
        }
    }
}
