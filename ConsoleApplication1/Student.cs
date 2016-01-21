using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Student
    {
        // private members, can not be seen outside class

        private int age;
        private string firstName;

        // public memebers, but not often
        public string Name;

        // properties, all properties must be public
        // get  and set method,
        // Why not using simplified?
        public int Age {
            get {
                return age;
            }
            set {

                if (age < 0)
                {
                    throw new Exception();
                }
                age = value;
            }
        }

        // Simplified property

        public string LastName { get; set; }

        //Constructor, looks like a method
        // It is not a method, because it does not have any return type

        public Student()
        {
            age = 9;
        }

        public Student(int _age)
        {
            age = _age;
        }
    }
}
