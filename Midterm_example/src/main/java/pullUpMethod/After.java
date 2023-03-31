package pullUpMethod;

class Employee{
    /**
     *- Putting duplicated method to superclass Employee
     *- Delete duplicated method on subclas Saleman and Engineer
     */
    public String getName(){
        /** ... */
        return "";
    }
}

class Saleman extends Employee{
}

//File Engineer.java
class Engineer extends Employee{
}
