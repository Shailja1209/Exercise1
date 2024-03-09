using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Polymorphism
    {
        public void Sum()
        {
            Console.WriteLine("I am sum method");
        }
        public void Sum(int a)
        {
            Console.WriteLine("I am sum method");
        }
        public void Sum(string a)
        {
            Console.WriteLine("I am sum method");
        }
        public void Sum(string a, string b)
        {
            Console.WriteLine("I am sum method");
        }
        public int a;
       
    }
}
