using System;
namespace EmpWage
{
    internal class Program
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;

        public static int empwage(string company, int Rate_Per_Hour, int Working_Days, int Max_Hrs)
        {
            int Hrs = 0;
            int TotalWage = 0;
            int TotalHrs = 0;
            int TotalDays = 0;

            while (TotalHrs <= Max_Hrs && TotalDays < Working_Days)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        Hrs = 4;
                        break;
                    case IS_FULL_TIME:
                        Hrs = 8;
                        break;
                    default:
                        Hrs = 0;
                        break;
                }

                TotalHrs += Hrs;
                TotalDays++;
                Console.WriteLine("Days : " + TotalDays + "Employee Hours : " + TotalHrs);
            }

            TotalWage = TotalHrs * Rate_Per_Hour;
            Console.WriteLine("Total Employee Wage is " + TotalWage);
            return TotalWage;
        }
        public static void Main(string[] args)
        {
            empwage("DMART", 20, 20, 100);
            empwage("Relaiance", 20, 20, 100);
        }
    }
}