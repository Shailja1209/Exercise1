// See https://aka.ms/new-console-template for more information

//Q1
//Console.WriteLine("The first 10 natural number:");
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

////Q2
//int sum = 0;
//Console.WriteLine("The first 10 natural numbers are:");
//for (int j = 1; j <= 10; j++)
//{
//    sum = sum + j;
//    Console.WriteLine(j);
//}
//Console.WriteLine("The sum is: " + sum);

////Q3
//Console.WriteLine("Please enter value of n");
//int n = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//Console.WriteLine("The first n natural numbers are:");
//for (int j = 1; j <= n; j++)
//{
//    sum = sum + j;
//    Console.WriteLine(j);
//}
//Console.WriteLine("The sum of n natural number: " + sum);


//Q5
//Console.WriteLine("Please enter your number");
//int n = Convert.ToInt32(Console.ReadLine());
//    for (int i = 1; i <= n; i++)
//    {
//        int j = i * i * i;
//        Console.WriteLine("Number is: " + i + " and cube of the " + i + " is: " + j);
//    }

//Q6
//Console.WriteLine("Please enter your number");
//int n = Convert.ToInt32(Console.ReadLine());
//    for (int i = 1; i <= 10; i++)
//    {
//        int j = n * i;
//        Console.WriteLine(n + " X " + i + " = " + j);
//    }

//Q7
//Console.WriteLine("Please enter number upto the table number starting from 1 to ");
//int n = Convert.ToInt32(Console.ReadLine());
//    for (int i = 1; i <= 10; i++)
//    {
//        for (int k = 1; k <= n; k++)
//        {
//            int j = i * k;
//            Console.WriteLine(k + " X " + i + " = " + j);
//        }
//    }

//Q8
//Console.WriteLine("Please enter your terms");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("The odd numbers are");
//int sum = 0;
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(2*i-1);
//    sum += 2 * i - 1;
//}
//Console.WriteLine("The sum of even natural number upto {0}, is {1}", n, sum);

//Q9
//Console.WriteLine("Please enter number of row");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.Write("\n");
//}

//Q10
//Console.WriteLine("Please enter number of row");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    for(int j = 1; j<= i; j++)
//    {
//        Console.Write(j);
//    }
//    Console.Write("\n");
//}

////Q11
//Console.WriteLine("Please enter number of row");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(i);
//    }
//    Console.Write("\n");
//}

//Q14
//Console.WriteLine("Please enter your row");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    for (int j = n;  j >= 1; j--)
//    {
//        if (i >= j)
//            Console.Write("* ");
//        else
//            Console.Write(" ");
//    }
//    Console.Write("\n");
//}


//Q15
//Console.WriteLine("Please enter your number");
//int n = Convert.ToInt32(Console.ReadLine());
//int f = 1;
//for (int i = 1; i <= n; i++)
//{
//    f = f * i;
//}
//Console.WriteLine("The factorial of {0} is {1}", n, f);

//Q16
//using System.Diagnostics.CodeAnalysis;

//Console.WriteLine("Please enter your terms");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("The even numbers are");
//int sum = 0;
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(2*i);
//    sum += 2 * i;
//}
//Console.WriteLine("The sum of even natural number upto {0}, is {1}", n, sum);

//Q19
//using System.Diagnostics.CodeAnalysis;

//Console.WriteLine("Please enter number of terms");
//int n = Convert.ToInt32(Console.ReadLine());
//float sum = 0;
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine("1/{0}", i);
//    sum = sum + 1 / (float)i;
//}
//Console.WriteLine("sum of the series upto {0} terms : {1}", n, sum);


//Q25
//Console.WriteLine("Please enter your terms");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("The square natural numbers are");
//int sum = 0;
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(i * i);
//    sum += i * i;
//}
//Console.WriteLine("The sum of even natural number upto {0}, is {1}", n, sum);

///////////////////////////////////////////////////////////////////////////////////////////////

//using ITExpertsEraSep2023;

//Car ObjCar = new Car();
//ObjCar.Name = "i20";
//ObjCar.Brand = "Hyndai";
//ObjCar.Color = "Red";
//ObjCar.NoOfSeats = 4;

//Console.WriteLine("Name of the Car is " + ObjCar.Name);
//Console.WriteLine("Brand of the Car is " + ObjCar.Brand);
//Console.WriteLine("Colour of the Car is " + ObjCar.Color);
//Console.WriteLine("No. of seats of the Car is " + ObjCar.NoOfSeats);

//ObjCar.Accelerator(10);
//ObjCar.Brake(5);
//ObjCar.Clutch(10);

////Console.WriteLine("//////////////////////////////////////////////////////////////////////////");

//Car ObjCar1 = new Car();
//ObjCar1.Name = "Verna";
//ObjCar1.Brand = "Hyndai";
//ObjCar1.Color = "Black";
//ObjCar1.NoOfSeats = 4;

//Console.WriteLine("Name of the Car is " + ObjCar1.Name);
//Console.WriteLine("Brand of the Car is " + ObjCar1.Brand);
//Console.WriteLine("Colour of the Car is " + ObjCar1.Color);
//Console.WriteLine("No. of seats of the Car is " + ObjCar1.NoOfSeats);

//ObjCar1.Accelerator(20);
//ObjCar1.Brake(2);
//ObjCar1.Clutch(100);

//Console.WriteLine("//////////////////////////////////////////////////////////////////////////");

//using Exercise1;

//Student ObjStudent1 = new Student();
//ObjStudent1.Name = "Ram";
//ObjStudent1.FName = "Ramesh Singh";
//ObjStudent1.RollNumber = 1234;
//ObjStudent1.Age = 14;

//Console.WriteLine("Name of the Student is " + ObjStudent1.Name);
//Console.WriteLine("Father's name of the student is " + ObjStudent1.FName);
//Console.WriteLine("Roll Number of the Student is " + ObjStudent1.RollNumber);
//Console.WriteLine("Age of the Student is " + ObjStudent1.Age);

//ObjStudent1.FirstSem(420);
//ObjStudent1.SecondSem(450);
//ObjStudent1.ThirdSem(428);
//ObjStudent1.FourthSem(463);

//Console.WriteLine("================================================");

//Student ObjStudent2 = new Student();
//ObjStudent2.Name = "Ravi";
//ObjStudent2.FName = "Suresh Singh";
//ObjStudent2.RollNumber = 1222;
//ObjStudent2.Age = 14;

//Console.WriteLine("Name of the Student is " + ObjStudent2.Name);
//Console.WriteLine("Father's name of the student is " + ObjStudent2.FName);
//Console.WriteLine("Roll Number of the Student is " + ObjStudent2.RollNumber);
//Console.WriteLine("Age of the Student is " + ObjStudent2.Age);

//ObjStudent2.FirstSem(320);
//ObjStudent2.SecondSem(368);
//ObjStudent2.ThirdSem(388);
//ObjStudent2.FourthSem(476);

//Console.WriteLine("================================================");

//using Exercise1;
//Employee ObjEmployee1 = new Employee();
//ObjEmployee1.EmpName = "Rohit";
//ObjEmployee1.EmpID = 32435;
//ObjEmployee1.PhNo = 9876098776;
//ObjEmployee1.Gender = "Male";

//Console.WriteLine("Name of the Employee is " + ObjEmployee1.EmpName);
//Console.WriteLine("Employee ID is " + ObjEmployee1.EmpID);
//Console.WriteLine("Phone Number of the Employee is " + ObjEmployee1.PhNo);
//Console.WriteLine("Gender of the Employee is " + ObjEmployee1.Gender);

//ObjEmployee1.BasicSalary(40000);

//Console.WriteLine("================================================");
//Employee ObjEmployee2 = new Employee();
//ObjEmployee2.EmpName = "Riya";
//ObjEmployee2.EmpID = 32444;
//ObjEmployee2.PhNo = 9803468776;
//ObjEmployee2.Gender = "Female";

//Console.WriteLine("Name of the Employee is " + ObjEmployee2.EmpName);
//Console.WriteLine("Employee ID is " + ObjEmployee2.EmpID);
//Console.WriteLine("Phone Number of the Employee is " + ObjEmployee2.PhNo);
//Console.WriteLine("Gender of the Employee is " + ObjEmployee2.Gender);

//ObjEmployee1.BasicSalary(30000);

/////////////////////////////////////////////////////////////////////
//using Exercise1;

//Fan ObjFan1 = new Fan();
//ObjFan1.Brand = "Havells";
//ObjFan1.Colour = "White";
//ObjFan1.Type = "Ceiling Fan";
//ObjFan1.NoOfBlade = 4;

//Console.WriteLine("Brand of the fan is " + ObjFan1.Brand);
//Console.WriteLine("Colour of the fan is " + ObjFan1.Colour);
//Console.WriteLine("Fan type is " + ObjFan1.Type);
//Console.WriteLine("No. of blades is " + ObjFan1.NoOfBlade);

//string Rotate = ObjFan1.Rotate();
//Console.WriteLine(Rotate);
//////////////////////////////////////////////////
//using Exercise1;

//Mobile ObjMob1 = new Mobile();
//ObjMob1.Name = "S20";
//ObjMob1.BrandName = "Samsung";
//ObjMob1.Colour = "Black";
//ObjMob1.Ram = 8;
//ObjMob1.HardDisk = 128;

//string call = ObjMob1.Call();
//string message = ObjMob1.Message();

//Console.WriteLine("Call method is " + call);
//Console.WriteLine("Message method is " + message);

//////////////////////////////////////////////////////
//using Exercise1;
//Person ObjPerson = new Person();
//ObjPerson.Name = "Rahul";
//ObjPerson.Age = 32;
//ObjPerson.Height = 160;
//ObjPerson.Gender = "Male";

//Console.WriteLine("Name of the Person is " + ObjPerson.Name);
//Console.WriteLine("Age of the person is " + ObjPerson.Age);
//Console.WriteLine("Height of the person is " + ObjPerson.Height);
//Console.WriteLine("Gender of the person is " + ObjPerson.Gender);

//ObjPerson.TimeInHour(5);
//////////////////////////////////////////////////////////

//Polymorphism
//using Exercise1;
//Polymorphism objPE = new Polymorphism();
//objPE.Sum();
//objPE.Sum(22);
//objPE.Sum("abcd");
///////////////////////////////////////////////////////////
//objPE.a = 100;
//Polymorphism objPE2 = new Polymorphism();
//objPE2.a = objPE.a;
//objPE = null;
//Console.WriteLine(objPE2.a);
/////////////////////////////////////////////////////

//using Exercise1;
//B objB = new B();

using Exercise1;

//A1 objA1 = new A1();
//objA1.TestMethod();
//B1 objB1 = new B1();
//objB1.TestMethod();
////////////////////////////////////////////////////

TestClass objTest = new TestClass();
objTest.Add(10, 20);


Console.Read();