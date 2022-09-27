using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.ClassTypes
{
    public abstract class AbstractClass
    {
        public int a, b;
        public AbstractClass(int x, int y)  // decalaring Paremetrized Constructor with ing x,y parameter
        {
            a = x;
            b = y;
        }
        static AbstractClass()
        {

        }

        public AbstractClass()
        {

        }

        /// <summary>
        /// Private Constructor--
        /// It is not possible for other classes to derive from this class, 
        /// neither is it possible to create an instance of this class. 
        /// One use of a private constructor is when we have only static members.
        /// It provides an implementation of a singleton class pattern
        /// </summary>
        private AbstractClass(int z)
        {

        }

        public AbstractClass(AbstractClass staticClass) //Copy Constructor
        {

        }
    }
}
