package replaceDelegationWithInheritance;

/**
 * - Make class Employee a subclass of class Person
 * - Create method getName in superclass Person
 * - Delete method getName in now subclass Employee
 * - Delete delegate field person in subclass Employee
 */
class Person{
    String getName(){/** ... */}
}
class Employee extends Person{}
