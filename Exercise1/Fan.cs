using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Fan
    {
        public string Brand { get; set; }
        public string Colour { get; set; }
        public string Type { get; set; }
        public int NoOfBlade { get; set; }
        public string Rotate()
        {
            string result = "Fan is rotating";
            return result;
        }
    }


}
