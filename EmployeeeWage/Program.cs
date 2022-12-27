using System;

namespace EmployeeeWage
{
    internal class Program
    {
        public const int FullTime = 1;
        public const int PartTime = 2;



        public static int computeEmpWage(string company, int EmpRatePerHr, int NumberofWorkingDays, int MaxHrsInMonth)
        {
            int EmpHrs = 0, TotalEmpHrs = 0, totalworkingdays = 0;

            while (TotalEmpHrs <= MaxHrsInMonth && totalworkingdays < NumberofWorkingDays)

            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case PartTime:
                        EmpHrs = 4;
                        break;
                    case FullTime:
                        EmpHrs = 8;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }

                TotalEmpHrs = TotalEmpHrs + EmpHrs;
                Console.WriteLine("day:" + totalworkingdays + " employee hours: " + EmpHrs);
            }
            int TotalEmpWage = TotalEmpHrs * EmpRatePerHr;

            Console.WriteLine("total employee wage:" + TotalEmpWage);
            return TotalEmpWage;

        }
        static void Main(string[] args)
        {
            computeEmpWage("LNT", 20, 28, 100);
            computeEmpWage("Relaince", 25, 30, 110);
        }
    }
}