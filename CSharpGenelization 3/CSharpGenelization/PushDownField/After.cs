using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.PushDownField
{
    internal class After
    {
        class Employee { }

        class Saleman : Employee {
            //Create field quota to subclass.
            //Delete field quota in superclass Employee.
            int quota;
        }

        class Engineer : Employee { }
    }
}
