package pullUpField;

/**
 * Subclass Saleman and Engineer have duplicated
 * field name.
 */
class Employee{
}
class Saleman : Employee{
    /**
     * Duplicated field
     */
    private String name;

}

class Engineer extends Employee{
    /**
     * Duplicated field
     */
    private String name;
}
