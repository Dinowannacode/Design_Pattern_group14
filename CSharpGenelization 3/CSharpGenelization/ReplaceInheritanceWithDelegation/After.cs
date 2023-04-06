using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.ReplaceInheritanceWithDelegation
{
    internal class After
    {

        //- Create method isEmployee in subclass Stack
        // - Create new delegate field vector holding superclass Vector
        // in Stack class
        // - Change return type of method isEmpty in subclass Stack
        // from this to vector
        class Vector
        {
            delegate bool isEmpty();
        }

        class Stack{
            Vector isEmpty() { }
        }
    }
}
