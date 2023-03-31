package formTemplateMethod;

class Site{
    int unit;
    double rate;
    double TAX_RATE;

}

/**
 * ResidentialSite class and LifelineSite class
 * have the same method name but do different steps.
 */
class ResidentialSite extends Site{
    double base;
    double tax;
    double getBillableAmount(int unit,double rate){
        base = unit * rate;
        tax = base * TAX_RATE;

        return base*tax;
    }

}
class LifelineSite extends Site{
    double base;
    double tax;
    double getBillableAmount(int unit, double rate){
        base =  (unit * rate * 0.5);
        tax = base * TAX_RATE;

        return base*tax;
    }
}