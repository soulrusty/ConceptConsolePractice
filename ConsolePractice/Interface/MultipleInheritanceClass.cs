using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.Interface
{
    public interface InterfaceA
    {
        void PrintA();
    }
    public interface InterfaceB
    {
        void PrintB();
    }
    public interface InterfaceC
    {
        void PrintC();
    }
    public class MultipleInheritanceClass : InterfaceA, InterfaceB, InterfaceC
    {
        public void PrintA()
        {
            Console.WriteLine("PrintA");
        }
        public void PrintB()
        {
            Console.WriteLine("PrintB");
        }
        public void PrintC()
        {
            Console.WriteLine("PrintC");
        }
    }
}
