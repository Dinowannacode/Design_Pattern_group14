using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.ReplaceInheritanceWithDelegation
{
    internal class Before
    {
        //Subclass Stack only use method isEmpty from
        //superclass Vector
        class Vector
        {
            bool isEmpty() { }
        }

        class Stack : Vector { }
    }
}
