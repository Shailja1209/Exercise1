using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Mobile
    {
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string Colour { get; set; }
        public int Ram { get; set; }
        public int HardDisk { get; set; }

        public string Call()
        {
            string result = "Call is going on";
            return result;
        }
        public string Message()
        {
            string result = "Message delivered successfully";
            return result;
        }
    }
}

 
