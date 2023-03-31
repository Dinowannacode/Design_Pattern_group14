package pushDownMethod;

class Employee{
    /**
     * This method is only making sense in subclass Saleman.
     */
    int getQuota();
}

class Saleman extends Employee {

}
class Engineer extends Employee {

}

