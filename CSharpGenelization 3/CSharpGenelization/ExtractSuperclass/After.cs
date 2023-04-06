using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.ExtractSuperclass
{
    internal class After
    {

        //- Create a superclass named Party
        //- Use pull up method on getAnnualCost()
        //
        abstract class Party
        {
            protected abstract int getAnnualCost();
            protected abstract String getName();
        }

        /**
         * Department class and Employee class is now a subclass
         * of the Party class
         */
        class Department : Party
        {
            protected override int getAnnualCost() { } /**Call from superclass*/
            int getHeadCount() { }
        }
        class Employee : Party
        {
            protected override int getAnnualCost() { } /**Call from superclass*/
            getId() { }
        }
    }
}
