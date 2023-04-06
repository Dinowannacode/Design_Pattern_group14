using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.CollapseHierarchy
{
    internal class Before
    {
        class Employee {
            String getName() { }
            String getDescription() { }
        }

        //This subclass doesn't serve anything other than
        //have the method isEmployed() that
        //check if person in salesman is employed.

        class Saleman : Employee
        {
            bool isEmployed() { }
        }

    }
}
