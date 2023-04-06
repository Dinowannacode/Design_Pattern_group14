using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.ExtractSubclass
{
    internal class After
    {
        class JobItem
        {
            int getTotalPrice() { }
            int getUnitPrice() { }
        }

        //- Create new subclass LaborItem
        //- Move method getUnitPrice and getEmployee from now superclass JobItem
        //to subclass LaborItem
        //- Delete old field getEmployee from superclass

        class LaborItem : JobItem
        {
        int getUnitPrice() { }
        String getEmployee() { }
        }
    }
}

