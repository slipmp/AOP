using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.Domain.Interceptor.SimpleInjector;

namespace AOP.Domain.Interceptor
{
    public class SimpleInjectorInterceptor : IInterceptor
    {
        #region IInterceptor Members

        public void Intercept(IInvocation invocation)
        {
            try
            {
                Console.WriteLine("Simple Injector Interceptor Called on method " + invocation.GetConcreteMethod().Name);

                invocation.Proceed();

                Console.WriteLine("Simple Injector Interceptor was successfully executed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Simple Injector An error has occured calling Interceptor. Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Simple Injector Interceptor - Finally");
            }
        }

        #endregion
    }
}
