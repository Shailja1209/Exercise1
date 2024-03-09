using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSep2023
{
    public class Car
    {
        public int speed = 10;
        //create new variable
        public int NumberOfSeats = 6;
        public string Colour = "Red";
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int NoOfSeats { get; set; }

        public void Accelerator(int pressure)
        {
            int CurrentSpeed = speed * pressure;
            Console.WriteLine("Current speed of the car is " + CurrentSpeed);
        }
        public void Brake(int pressure)
        {
            int CurrentSpeed = speed / pressure;
            Console.WriteLine("Current speed of the car is " + CurrentSpeed);
        }
        public void Clutch(int pressure)
        {
            int CurrentSpeed = speed;
            Console.WriteLine("Current speed of the car is " + CurrentSpeed);
        }
    }
}
