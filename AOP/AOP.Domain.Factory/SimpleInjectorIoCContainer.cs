using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.Domain.Implementation;
using AOP.Domain.Interface;
using AOP.Domain.Interceptor;
using AOP.Domain.Interceptor.SimpleInjector;
using SimpleInjector;

namespace AOP.Domain.Factory
{
    public class SimpleInjectorIoCContainer : IContainer
    {
        public T Resolve<T>()
        {
            var container = new Container();

            container.InterceptWith<SimpleInjectorInterceptor>(serviceType => serviceType.Name.EndsWith("Service")); 
            container.Register<IPressReleaseService, PressReleaseService>();
            
            return (T)container.GetInstance(typeof(T));
        }
    }
}
