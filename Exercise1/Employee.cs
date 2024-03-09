using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Employee
    {
        decimal Basic = 0;
        public string EmpName { get; set; }
        public float EmpID { get; set; }
        public double PhNo { get; set; }
        public string Gender { get; set; }

        public void BasicSalary(decimal Basic)
        {
            decimal BasicSalary = Basic;
            decimal HRA = (Basic * 40) / 100;
            decimal EPF = (Basic * 12) / 100;
            decimal TotalSalary = (Basic + HRA - EPF);

            Console.WriteLine("Basic salary of the employee is " + BasicSalary);
            Console.WriteLine("HRA of the employee is " + HRA);
            Console.WriteLine("EPF of the employee is " + EPF);
            Console.WriteLine("Total salary of the employee is " + TotalSalary);
        }
        
    }
}
