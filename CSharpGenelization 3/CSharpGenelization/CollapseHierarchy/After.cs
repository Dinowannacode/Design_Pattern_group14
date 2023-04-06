using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.CollapseHierarchy
{
    internal class After
    {

        //- Create method IsEmployed() on superclass Employee
        //- Delete method IsEmployed() on subclass Saleman
        //- Delete subclass Saleman as it doesn't serve anything

        class Employee
        {
            String getName() { }
            String getDescription() { }
            bool isEmployed() {}
        }
    }
}
