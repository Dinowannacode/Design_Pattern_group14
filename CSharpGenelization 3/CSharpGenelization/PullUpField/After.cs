using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.PullUpField
{
    internal class After
    {
        class Employee
        {
            //- Putting duplicate field to superclass Employee.
            //- Delete duplicate field on subclass Saleman and Engineer.
            protected String name;
        }

        class Saleman : Employee { }

        class Engineer : Employee { }
    }

}
