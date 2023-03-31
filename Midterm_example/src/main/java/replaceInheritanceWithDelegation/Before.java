package replaceInheritanceWithDelegation;

/**
 * Subclass Stack only use method isEmpty from
 * superclass Vector
 */
class Vector{
    boolean isEmpty();
}

class Stack extends Vector {}
