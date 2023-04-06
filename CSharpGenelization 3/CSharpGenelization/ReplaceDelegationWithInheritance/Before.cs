using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.ReplaceDelegationWithInheritance
{
    internal class Before
    {
        //There is delegate class person in subclass Employee.
        class Person
        {
            delegate String getName();
        }

        class Employee
        {
            Person getName() { }
        }
    }
}
