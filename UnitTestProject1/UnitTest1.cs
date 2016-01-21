using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestStudent
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            Student student = new Student();

            Assert.AreEqual(student.Age, 8);

        }

        [TestMethod]
        public void TestConstructorWithAge()
        {
            Student student = new Student(120);

            Assert.AreEqual(student.Age, 120);

        }
    }
}
