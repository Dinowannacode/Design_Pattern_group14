package pullUpConstuctorBody;

/**
 *- Create constructor on superclass Employee
 *- Manager now use super() to call from superclass
 * instead of creating constructor
 */
class Employee{
    protected String name;
    protected String id;
    public Employee(String name, String id) {
        this.name = name;
        this.id = id;
    }
}

class Manager extends Employee{
    private int grade;
    /**
     * Calling super() on subclass
     */
    public Manager(String name, String id, int grade) {
        super(name, id);
        this.grade = grade;
    }
}
