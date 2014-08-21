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

namespace AOP.Domain.Factory
{
    public class CastleWindsorIoCContainer : IContainer
    {
        public T Resolve<T>()
        {
            // CREATE A WINDSOR CONTAINER OBJECT AND REGISTER THE INTERFACES, AND THEIR CONCRETE IMPLEMENTATIONS.
            var container = new WindsorContainer();

            container.Register(
            Component.For<IInterceptor>().ImplementedBy<CastleWindsorInterceptor>());

            container.Register(Component.For<IPressReleaseService>().ImplementedBy<PressReleaseService>()
                .Interceptors(InterceptorReference.ForType<CastleWindsorInterceptor>()).Anywhere);
               
            return container.Resolve<T>();
        }
    }
}
