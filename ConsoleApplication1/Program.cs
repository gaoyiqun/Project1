using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        // this can not be changed
        static void Main(string[] args)
        {
            TestStudent();

        }
        // This is a function, where a and b are parameters
        static void ChangeValuesTest(int a, MyClass b)
        {
            // if I change b.AnInt , the changes will be seen on the b
            b.AnInt = a;
            // This does not change original value, because it is value type
            a = 6;
           
        }

        static void Test1()
        {
            MyClass myclass = new MyClass();
            myclass.AnInt = 5;
            int anint = 4;
            ChangeValuesTest(anint, myclass);
            // myclass.AnInt is changed!
            Console.WriteLine(myclass.AnInt);
            // anint will not be changed as it is value type
            Console.WriteLine(anint);

            Console.Read();
        }

        static void TestStudent()
        {
            Student studentTest = new Student();
            // this is using a different constructor judging from the parameter passed in 
            Student studentTest2 = new Student(10);
            studentTest.Age = -2;
            Console.WriteLine(studentTest.Age);

            studentTest.LastName = "Joe";
            Console.WriteLine(studentTest.LastName);

            Console.Read();
        }
    }
}
