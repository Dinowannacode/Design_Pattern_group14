package extractSuperclass;

/**
 *These two class have similar features
 */
class Department{
    getTotalAnnualCost(); /** This does the same thing
                              with getAnnualCost() on Employee class*/
    getName();
    getHeadCount();
}
class Employee{
    getAnnualCost(); /** This does the same thing
                        with getTotalAnnualCost() on Department class*/
    getName();
    getId();
}