using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class MyClass1
    {
        // this is method
        // The return type is MyClass
        public MyClass MyMethod()
        {
            return new MyClass();

        }

        public List<Student> GetStudents()
        {
            List<Student> list1 = new List<Student>();
            // student1 is an instance of Student class
            Student student1 = new Student();
            Student student2 = new Student();
            list1.Add(student1);
            list1.Add(student2);

            return list1;
        }
    }
}
