using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise1
{
    public class Student
    {
        public decimal TotalMarks = 500;
        public string Name { get; set; }
        public string FName { get; set; }
        public int RollNumber { get; set; }
        public int Age { get; set; }


        public void FirstSem(int Marks)
        {
            decimal FirstSemPercentage = (Marks / TotalMarks) * 100;
            Console.WriteLine("Percentage in First Semester is " + FirstSemPercentage);
        }
        public void SecondSem(int Marks)
        {
            decimal SecondSemPercentage = (Marks / TotalMarks) * 100;
            Console.WriteLine("Percentage in Second Semester is " + SecondSemPercentage);
        }
        public void ThirdSem(int Marks)
        {
            decimal ThirdSemPercentage = (Marks / TotalMarks) * 100;
            Console.WriteLine("Percentage in Third Semester is " + ThirdSemPercentage);
        }
        public void FourthSem(int Marks)
        {
            decimal FourthSemPercentage = (Marks / TotalMarks) * 100;
            Console.WriteLine("Percentage in Fourth Semester is " + FourthSemPercentage);
        }




    }

}
