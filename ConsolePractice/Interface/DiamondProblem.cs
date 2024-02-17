using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.Interface
{
    /// <summary>
    /// The "diamond problem" is an ambiguity that arises when two classes B and C 
    /// inherit from A, and class D inherits from both B and C. 
    /// If there is a method in A that B and C have overridden,and D does not override it, 
    /// then which class of the method does D inherit: that of B, or that of C? 
    /// So this is an ambiguity problem in multiple inheritances in c#.
    /// So that c# does not support multiple inheritances. 
    /// It also called an ambiguity problem in c#.
    /// </summary>
    interface IMother
    {
        void Loan();
    }
    interface IFather
    {
        void Loan();
    }
    public class Mother : IMother
    {
        public void Loan()
        {
            Console.WriteLine("Loan taken by mother.");
        }
    }
    public class Father : IFather
    {
        public void Loan()
        {
            Console.WriteLine("Loan taken by father");
        }
    }
    public class Child : IMother, IFather
    {
        void IMother.Loan()
        {
            Console.WriteLine("Mother's loan paid by child");
        }

        void IFather.Loan()
        {
            Console.WriteLine("Father's loan paid by child");
        }
    }

    public class CallInterfaceMthodsExample
    {
        public static void CallInterfaceMethods()
        {
            // The first way to creating the instance of the class and typecast the interface type.   
            Child child = new Child();
            ((IMother)child).Loan();
            ((IFather)child).Loan();

            // Second Way creating an object of the class and reference variable of the interface type.  

            IMother vendor = new Child();
            vendor.Loan();
            IFather supplier = new Child();
            supplier.Loan();
        }
    }

}
