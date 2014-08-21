using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace AOP.Domain.Interceptor
{
    public class UnityInterceptor : IInterceptionBehavior
    {
        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            IMethodReturn result = null;
            try
            {
                Console.WriteLine("UnityInterceptorInterceptor Called on method " + input.MethodBase.Name);

                result = getNext()(input, getNext);

                Console.WriteLine("UnityInterceptor Interceptor was successfully executed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("UnityInterceptor An error has occured calling Interceptor. Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("UnityInterceptor Interceptor - Finally");
            }
            return result;
        }

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public bool WillExecute
        {
            get { return true; }
        }
    }
}
