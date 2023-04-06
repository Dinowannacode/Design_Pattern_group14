using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.ExtractSuperclass
{
    internal class Before
    {

        //These two classes have similar features

        class Department
        {
            double getTotalAnnualCost() { } // This method does the same thing
                                  // with getAnnualCost() on Employee class
            String getName() { ]}
            int getHeadCount() { }
        }
        class Employee
        {
            double getAnnualCost() { } //This does the same thing
                                       // with getTotalAnnualCost() on Department class
            String getName() { }

            String getId() { }
        }
    }
}
