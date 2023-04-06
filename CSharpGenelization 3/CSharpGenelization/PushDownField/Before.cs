using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.PushDownField
{
    internal class Before
    {
        internal class After
        {
            class Employee
            {
                //This field only see using in subclass Saleman
                int quota;
            }

            class Saleman : Employee { }

            class Engineer : Employee { }
        }
    }
}
