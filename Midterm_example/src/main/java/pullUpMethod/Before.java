package pullUpMethod;


/**
 * Subclass Saleman and Engineer have duplicated method
 * named getName()
 */
class Employee{

}

class Saleman extends Employee{
    /**
     * Duplicated method.
     */
    public String getName(){
        /** ... */
        return "";
    }

}

class Engineer extends Employee{
    /**
     * Duplicated method.
     */
    public String getName(){
        /** ... */
        return "";
    }
}
