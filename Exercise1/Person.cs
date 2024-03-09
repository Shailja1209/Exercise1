using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Person
    {
        public int Speed = 50;
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public string Gender { get; set; }
        public void TimeInHour (int Time)
        {
            int Distance = Speed * Time;
            Console.WriteLine(Name + " travels " + Distance + " km in " + Time + " Hour");

        }
    }
}
