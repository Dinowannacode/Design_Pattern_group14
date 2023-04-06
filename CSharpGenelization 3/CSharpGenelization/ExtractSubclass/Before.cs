using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.ExtractSubclass
{
    internal class Before
    {
        class JobItem
        {
             //We want to move
             //method getUnitPrice() and getEmployee()
             //to a new subclass
            int getTotalPrice() { }
            int getUnitPrice() { }
            String getEmployee() { }
        }
    }
}
