using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.ClassTypes
{
    public sealed class SealedClass
    {
        static SealedClass()
        {

        }

        public SealedClass()
        {

        }

        /// <summary>
        /// Private Constructor--
        /// It is not possible for other classes to derive from this class, 
        /// neither is it possible to create an instance of this class. 
        /// One use of a private constructor is when we have only static members.
        /// It provides an implementation of a singleton class pattern
        /// </summary>
        private SealedClass(int x)
        {

        }

        public SealedClass(SealedClass staticClass) //Copy Constructor
        {

        }
    }
}
