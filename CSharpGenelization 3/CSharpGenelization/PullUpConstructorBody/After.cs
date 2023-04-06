using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.PullUpConstructorBody
{
    internal class After
    {
        //-Create constructor on superclass Employee
        //- Manager now only use base on constructor method 
        class Employee
        {
            protected String name;
            protected String id;
            public Employee(String name, String id)
            {
                this.name = name;
                this.id = id;
            }
        }

        class Manager : Employee
        {
            private int grade;
             //Doesn't have to call super() like in Java
             //just use base() on constructor method
            public Manager(String name, String id, int grade) : base(name, id)
            {
                this.grade = grade;
            }
    }
}
}
