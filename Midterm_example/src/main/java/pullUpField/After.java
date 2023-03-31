package pullUpField;

class Employee{
    /**
     * - Putting duplicate field to superclass Employee.
     * - Delete duplicate field on subclass Saleman and Engineer.
     */
    protected String name;
}

class Saleman extends Employee{
}

class Engineer extends Employee{
}
