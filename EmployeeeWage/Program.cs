using System;

namespace EmployeeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1, partTime = 2, Emp_Rate_Per_Hour = 20, empHrs = 0, empwage = 0;
            Random randobj = new Random();
            int checkPresent = randobj.Next(0, 3);
            Console.WriteLine("Random number=" + checkPresent);
            if (checkPresent == fullTime)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present");
            }
            else if (checkPresent == partTime)
            {
                empHrs = 4;
                Console.WriteLine("Employee is present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }

            empwage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage:" + empwage);
            switch (checkPresent)
            {
                case 1:
                    Console.WriteLine("Employee is fulltime");
                    break;
                case 2:
                    Console.WriteLine("Employee is parttime");
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }
        }

    }
}