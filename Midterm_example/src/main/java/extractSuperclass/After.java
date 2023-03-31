package extractSuperclass;

/**
 * - Create a superclass named Party
 * - Use pull up method on getAnnualCost()
 */
abstract class Party{
    abstract int getAnnualCost();
    getName();
}

/**
 * Department class and Employee class is now a subclass
 * of the Party class
 */
class Department extends Party{
    int getAnnualCost(); /**Call from superclass*/
    getHeadCount();
}
class Employee extends Party{
    int getAnnualCost(); /**Call from superclass*/
    getId();
}
