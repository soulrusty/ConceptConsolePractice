using System.Security.Cryptography.X509Certificates;
using static ConsolePractice.Delegate.DelegateClass;

namespace ConsolePractice.Delegate
{
    /// <summary>
    /// A delegate is a type that represents references to methods with a particular 
    /// parameter list and return type. When you instantiate a delegate, 
    /// you can associate its instance with any method with a compatible signature and 
    /// return type.You can invoke (or call) the method through the delegate instance.
    /// Delegates are used to pass methods as arguments to other methods.
    /// Event handlers are nothing more than methods that are invoked through delegates.
    /// You create a custom method, and a class such as a windows control can call your 
    /// method when a certain event occurs.The following example shows a delegate declaration:
    /// 
    /// Delegates are similar to C++ function pointers, but delegates are fully object-oriented,
    /// Delegates allow methods to be passed as parameters.
    /// Delegates can be used to define callback methods.
    /// Delegates can be chained together; 
    /// for example, multiple methods can be called on a single event.
    /// Methods don't have to match the delegate type exactly. 
    /// For more information, see Using Variance in Delegates. 
    /// Lambda expressions (in certain contexts) are compiled to delegate types.
    /// </summary>
    public class DelegateClass
    {
        public delegate int Del(int a, int b);

        public int DelegateMethod(int a, int b)
        {
            return a + b;
        }
    }

    public static class CallDelegateMethodExample
    {
       public static void CallDelegate()
        {
            //Delegate Practice.
            DelegateClass delegateClass = new DelegateClass();

            // Instantiate the delegate.
            Del handler = delegateClass.DelegateMethod;

            // Call the delegate.
            handler(6, 9);
        }

    }
}
