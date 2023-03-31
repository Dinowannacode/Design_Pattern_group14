package pullUpConstuctorBody;

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
     * Constructor on subclass
     * with mostly identical bodies.
     */
    public Manager(String name, String id, int grade) {
        this.name = name;
        this.id = id;
        this.grade = grade;
    }
}

