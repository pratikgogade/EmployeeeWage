using System;

namespace EmployeeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1, Emp_Rate_Per_Hour = 20, empHrs = 0, empwage = 0;
            Random randobj = new Random();
            int checkPresent = randobj.Next(fullTime);
            Console.WriteLine("Random number=" + checkPresent);
            if (checkPresent == fullTime)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            empwage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage:" + empwage);
        }
    }
}