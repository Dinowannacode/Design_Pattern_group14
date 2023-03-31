package replaceDelegationWithInheritance;

/**
 * There is delegate class person in subclass Employee.
 */
class Person {
    String getName(){/** ... */}
}

class Employee {
    private Person person;
    String getName(){
        return this.person.getName();
    }
}