using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.Inhertance
{
    internal class FClass
    {
        public virtual void CallMethod()
        {
            Console.WriteLine("This is a call from FClass");
        }
    }

    internal class GClass : FClass
    {
        public override void CallMethod() // override will allow to call this method 
        {
            Console.WriteLine("This is a call from GClass");
        }
    }

    internal class HClass : FClass
    {
        public void CallMethod()
        {
            Console.WriteLine("This is a call from HClass");
        }
    }
}
