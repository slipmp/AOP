using System;
using Ninject.Extensions.Interception;

namespace AOP.Domain.Interceptor
{
    public class NinjectInterceptor : Ninject.Extensions.Interception.IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                Console.WriteLine("Ninject Interceptor Called on method " + invocation.Request.Method.Name);

                invocation.Proceed();

                Console.WriteLine("Ninject Interceptor was successfully executed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ninject An error has occured calling Interceptor. Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Ninject Interceptor - Finally");
            }
        }
    }
}
