using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.FormTemplateMethod
{
    internal class After
    {

         //Applying Template method to this situation
         // - Split calculating step in getBillableaAmount to seperte method
         //   getBaseAmount and getTaxAmount
         // - Use pull up method on method getBillableAmount
         // - Use pull up method on getBaseAmount and getTaxAmount but leave
         //the calcualtion on subclass
         //- Pull up the main calcualtion to the superclass
         //
        abstract class Site
        {
            protected float basic;
            protected float tax;

            protected float getBillableAmount()
            {
                return this.getBaseAmount() + this.getTaxAmount();
            }

            protected abstract float getBaseAmount();
            protected abstract float getTaxAmount();
        }
        class ResidentialSite : Site
        {
            protected override float getBaseAmount()
            {
                return base.basic;
            }

            protected override float getTaxAmount()
            {
                return base.tax;
            }

        }

        class LifelineSite : Site
        {
            protected override float getBaseAmount()
            {
                return base.basic;
            }

            protected override float getTaxAmount()
            {
                return base.tax;
            }
        }
    }
}
