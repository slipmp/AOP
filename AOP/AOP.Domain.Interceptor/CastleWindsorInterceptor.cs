using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace AOP.Domain.Interceptor
{
    public class CastleWindsorInterceptor : IInterceptor
    {
        #region IInterceptor Members

        public void Intercept(IInvocation invocation)
        {
            try
            {
                Console.WriteLine("Interceptor Called on method " + invocation.Method.Name);
                
                invocation.Proceed();

                Console.WriteLine("Interceptor was successfully executed.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error has occured calling Interceptor. Error: "+ ex.Message);
            }
            finally
            {
                Console.WriteLine("Interceptor - Finally");
            }
        }

        #endregion
    }
}
