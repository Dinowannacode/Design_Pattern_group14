using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.PushDownMethod
{
    internal class Before
    {
        class Employee
        {
            //This method is only making sense in subclass Saleman.
            int getQuota() { }

        }

        class Saleman : Employee { }

        class Engineer : Employee { }
    }
}
