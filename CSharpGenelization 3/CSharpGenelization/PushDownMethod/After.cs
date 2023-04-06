using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.PushDownMethod
{
    internal class After
    {
        class Employee { }

        class Saleman : Employee
        {
            // - Pull method getQuota() to subclass Saleman.
            // - Delete method getQuota() in superclass Employee.
            int getQuota() { }
        }

        class Engineer : Employee { }
    }
}
