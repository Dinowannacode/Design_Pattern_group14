using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.ExtractInterface
{
    internal class Before
    {
        class Employee
        {
            public int getRate() { }
            public bool hasSpecialSkill() {}
            public String getName() {}
            public String getDepartment() {}
        }

        
         //Method charge call value from subclass Employee
         //but only  getRate() and hasSpecialSkill() are used.

        class Client : Employee
        {
            
             //This method doesn't use info from getName()
             //and getDepartment().

            double charge(Employee emp, int days)
            {
                int basic = base.getRate() * days;

                if (base.hasSpecialSkill())
                    return basic * 1.08;
                else return basic;
            }
        }
    }
}
