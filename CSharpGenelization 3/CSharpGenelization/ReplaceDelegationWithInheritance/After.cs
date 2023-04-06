using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.ReplaceDelegationWithInheritance
{
    internal class After
    {
        //Make class Employee a subclass of class Person
        // - Create method getName in superclass Person
        // - Delete method getName in now subclass Employee
        // - Delete delegate field person in subclass Employee
        class Person
        {
            String getName() {}
        }

        class Employee : Person { }

    }
}
