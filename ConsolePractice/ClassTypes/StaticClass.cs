using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.ClassTypes
{
    public static class StaticClass
    {
        static StaticClass()
        {

        }

        //public StaticClass()
        //{

        //}

        /// <summary>
        /// Private Constructor--
        /// It is not possible for other classes to derive from this class, 
        /// neither is it possible to create an instance of this class. 
        /// One use of a private constructor is when we have only static members.
        /// It provides an implementation of a singleton class pattern
        /// </summary>
        //private StaticClass() //cannot use private/public constructor in Static calss
        //{

        //}

        //public StaticClass(StaticClass staticClass) //Copy Constructor
        //{

        //}
    }
}
