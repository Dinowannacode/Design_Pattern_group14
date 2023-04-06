using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.PullUpField
{
    internal class Before
    {
        //Subclass Saleman and Engineer have duplicated
        //field name.

        class Employee { }
        class Saleman : Employee
        {
            //Duplicated field
            private String name;
        }

        class Engineer : Employee
        {
            //Duplicated field
            private String name;
        }
    }
}
