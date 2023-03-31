package replaceInheritanceWithDelegation;

/**
 * - Create method isEmployee in subclass Stack
 * - Create new delegate field vector holding superclass Vector
 * in Stack class
 * - Change return type of method isEmpty in subclass Stack
 * from this to vector
 */
class Vector {
    boolean isEmpty();
}

class Stack {
    private Vector vector;
    boolean isEmpty(){
        return this.vector.isEmpty();
    }
}
