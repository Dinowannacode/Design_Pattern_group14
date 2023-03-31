package extractInterface;

/**
 * - Call new interface Billable
 * - Declare getRate and hasSpecialSkill in interface
 * - Declare Employee class as implement interface Billable
 */
interface Billable	{
    interface int getRate();
    interface boolean hasSpecialSkill();
}
class Employee implements Billable	{
    String getName();
    String getDepartment();
    int getRate();
    boolean hasSpecialSkill();
}

class Client{
    /**
     * Change paramenter from Employee to Billable
     */
    double charge(Billable bill, int days){
        int base = bill.getRate() * days;

        if(bill.hasSpecialSkill())
            return base * 1.08;
        else return base;
    }
}
