using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.FormTemplateMethod
{
    internal class Before
    {
        class Site
        {
            int unit;
            double rate;
            double TAX_RATE;

            protected double getTaxRate()
            {
                return TAX_RATE;
            }
        }

        /**
         * ResidentialSite class and LifelineSite class
         * have the same method name but do different steps.
         */
        class ResidentialSite : Site
        {
            double basic;
            double tax;
            double getBillableAmount(int unit, double rate)
            {
                basic = unit * rate;
                tax = basic * base.getTaxRate();

                return basic * tax;
            }

        }
        class LifelineSite : Site
        {
            double basic;
            double tax;
            double getBillableAmount(int unit, double rate)
            {
                basic = (unit * rate * 0.5);
                tax = basic * base.getTaxRate();

                return basic * tax;
            }
        }
    }
}
