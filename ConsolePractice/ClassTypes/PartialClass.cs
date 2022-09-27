using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.ClassTypes
{
    public partial class PartialClass
    {
        static PartialClass()
        {

        }

        public PartialClass()
        {

        }

        /// <summary>
        /// Private Constructor--
        /// It is not possible for other classes to derive from this class, 
        /// neither is it possible to create an instance of this class. 
        /// One use of a private constructor is when we have only static members.
        /// It provides an implementation of a singleton class pattern
        /// </summary>
        private PartialClass(int x) //cannot use private/public constructor in Static calss
        {

        }

        public PartialClass(PartialClass staticClass) //Copy Constructor
        {

        }
    }
}