using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            Console.WriteLine("UnityInterceptorInterceptor Called on method " + input.MethodBase.Name);

            result = getNext()(input, getNext);

            if (result.Exception != null)
            {
                Console.WriteLine("UnityInterceptor An error has occured calling Interceptor. Error: " + result.Exception.Message);
                result.Exception = null;
                //the method you intercepted caused an exception
                //check if it is really a method
                if (input.MethodBase.MemberType == MemberTypes.Method)
                {
                    MethodInfo method = (MethodInfo)input.MethodBase;
                    if (method.ReturnType == typeof(void))
                    {//you should only return null if the method you intercept returns void
                        return null;
                    }
                    //if the method is supposed to return a value type (like int) 
                    //returning null causes an exception
                }
            }
            Console.WriteLine("UnityInterceptor Interceptor was successfully executed.");
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
