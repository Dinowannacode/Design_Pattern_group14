package collaspseHierarchy;

class Employee{
    String getName(){/** ... */}
    String getDescription(){/** ... */}
}

/**
 * This subclass doesn't serve anything other than
 * check if person in salesman is employed
 */
class Salesman extends Employee{
    boolean isEmployed(){/** ... */}
}
