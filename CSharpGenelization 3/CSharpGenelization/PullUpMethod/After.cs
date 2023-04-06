using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.PullUpMethod
{
    internal class After
    {

        //Putting duplicated method to superclass Employee
        //Delete duplicated method on subclas Saleman and Engineer
        class Employee
        {
            protected String getName()
            {
                return "";
            }
        }

        class Saleman : Employee { }

        class Engineer : Employee { }
    }
}
