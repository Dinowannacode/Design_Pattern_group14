using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.ExtractInterface
{
    internal class After
    {
        
         //- Call new interface Billable
         //- Declare getRate and hasSpecialSkill in interface
         //- Declare Employee class as implement interface Billable
         
        interface Billable
        {
            int getRate();
            bool hasSpecialSkill();
        }
        class Employee : Billable
        {
            public int getRate() { }
            public bool hasSpecialSkill() { }
            public String getName() { }
            public String getDepartment() { }
        }

    class Client
    {

        //Change paramenter from Employee to Billable
        double charge(Billable bill, int days)
        {
            int basic = bill.getRate() * days;

            if (bill.hasSpecialSkill())
                return basic * 1.08;
            else return basic;
        }
    }
}
}
