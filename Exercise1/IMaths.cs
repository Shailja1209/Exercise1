using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public interface IMaths
    {
        void Add(int a, int b);
        void TestMethod();
    }
    public interface ITest
    {
        void Test();
        void TestMethod();

    }
    public class ParentTestClass
    {
        public void ParentTestMethod()
        {
            Console.WriteLine("I am parent class test method");
        }
    }
    public class TestClass : ParentTestClass, IMaths, ITest
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        public void Test()
        {
            Console.WriteLine("I am test");

        }

        public void TestMethod()
        {
            Console.WriteLine("I am test method");

        }
    }
}
