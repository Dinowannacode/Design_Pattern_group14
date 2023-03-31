package pushDownField;

class Employee{
    /**
     * This field only see using in subclass Saleman
     * */
    int quota;
}

class Saleman extends Employee {

}
class Engineer extends Employee {

}

