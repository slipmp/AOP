using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core;
using AOP.Domain.Implementation;
using AOP.Domain.Interface;
using AOP.Domain.Interceptor;

using Ninject;
using Ninject.Extensions.Interception;
using Ninject.Extensions.Interception.Infrastructure.Language;

namespace AOP.Domain.Factory
{
    public class NinjectIoCContainer : IContainer
    {
        public T Resolve<T>()
        {
            var container = new StandardKernel();

            container.Bind<IPressReleaseService>().To<PressReleaseService>().Intercept().With<NinjectInterceptor>();

            return container.Get<T>();
        }
    }
}
