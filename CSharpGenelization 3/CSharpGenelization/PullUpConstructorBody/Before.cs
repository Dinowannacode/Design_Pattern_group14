using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenelization.PullUpConstructorBody
{
    internal class Before
    {
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
            //Constructor on subclass
            //with mostly identical bodies.
            public Manager(String name, String id, int grade) : base(name, id)
            {
                this.name = name;
                this.id = id;
                this.grade = grade;
            }
        }
    }
}
