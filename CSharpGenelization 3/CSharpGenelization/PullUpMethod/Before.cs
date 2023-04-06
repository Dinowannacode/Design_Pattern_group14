using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.PullUpMethod
{
    internal class Before
    {
        //Subclass Saleman and Engineer have duplicated method
        //named getName()

        class Employee
        {

        }

        class Saleman : Employee
        {
            //Duplicate method
            public String getName()
            {
                return "";
            }

        }

        class Engineer : Employee
        {
            //Duplicate method
            public String getName()
            {
                return "";
            }
        }
    }
}
