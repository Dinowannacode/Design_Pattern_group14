package extractInterface;

class Employee {
    int getRate(){/** ... */}
    boolean hasSpecialSkill(){/** ... */}
    String getName(){/** ... */}
    String getDepartment(){/** ... */}
}

/**
 * Method charge call value from class Employee
 * but only  getRate() and hasSpecialSkill() are used.
 */
class Client{
    /**
     * This method doesn't use info from getName()
     * and getDepartment().
     */
    double charge(Employee emp, int days){
        int base = emp.getRate() * days;

        if(emp.hasSpecialSkill())
            return base * 1.08;
        else return base;
    }
}
