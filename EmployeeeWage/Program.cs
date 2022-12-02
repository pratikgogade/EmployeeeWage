using System;

namespace EmployeeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1;
            Random randobj = new Random();
            int checkPresent = randobj.Next(fullTime);
            Console.WriteLine("Random number=" + checkPresent);
            if (checkPresent == fullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}