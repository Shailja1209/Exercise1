using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class A1
    {
        public virtual void TestMethod()
        {
            Console.WriteLine("I am parent class method");
        }
        //public void TestMethod()
        //{
        //    Console.WriteLine("I am parent class method");
        //}

    }
    public class B1 : A1
    {
        public override void TestMethod()
        {
            Console.WriteLine("I am override method");
        }
        //public new void TestMethod()
        //{
        //    Console.WriteLine("I am new method of child class with same name as class method");
        //}

    }
}

