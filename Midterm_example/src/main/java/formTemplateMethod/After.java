package formTemplateMethod;

/**
 * Applying Template method to this situation
 * - Split calculating step in getBillableaAmount to seperte method
 *   getBaseAmount and getTaxAmount
 * - Use pull up method on method getBillableAmount
 * - Use pull up method on getBaseAmount and getTaxAmount but leave
 * the calcualtion on subclass
 * - Pull up the main calcualtion to the superclass
 */
abstract class Site{
    protected float base;
    protected float tax;

    float getBillableAmount(){
        return this.getBaseAmount() + this.getTaxAmount();
    }

    abstract float getBaseAmount();
    abstract float getTaxAmount();
}
class ResidentialSite extends Site{
    float getBaseAmount(){
        return this.base;
    }

    float getTaxAmount(){
        return this.tax;
    }

}
class LifelineSite extends Site{
    float getBaseAmount(){
        return this.base;
    }

    float getTaxAmount(){
        return this.tax;
    }
}