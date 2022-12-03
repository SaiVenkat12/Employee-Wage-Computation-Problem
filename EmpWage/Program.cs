using System;
namespace EmpWage
{
   internal class Program
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int Rate_Per_Hour = 20;
        public const int Working_Days = 20;
        static void Main(string[] args)
        {
            int Hrs = 0;
            int wage = 0;
            int TotalWage = 0;

           for (int day = 0; day<Working_Days; day++)
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

                wage = Hrs * Rate_Per_Hour;
                TotalWage+= wage;
                Console.WriteLine("Employee Wage is " + wage);
            }
            
            Console.WriteLine("Total Employee Wage is " + TotalWage);
        }
    }
}