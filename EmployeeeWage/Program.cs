using System;

namespace EmployeeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1, partTime = 2, Emp_Rate_Per_Hour = 20, empHrs = 0, empwage = 0, Emp_Working_Days = 20, totalempwage = 0;
            for (int day = 0; day <= Emp_Working_Days; day++)
            {
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
                int days = 0;
                while (days < 20)
                {
                    Console.WriteLine("Total Wages Are " + days);
                    days++;
                }
                empwage = empHrs * Emp_Rate_Per_Hour;
                totalempwage += empwage;
                Console.WriteLine("Employee Wage:" + empwage);
            }
            Console.WriteLine("Total Wage " + totalempwage);
        }

    }
}