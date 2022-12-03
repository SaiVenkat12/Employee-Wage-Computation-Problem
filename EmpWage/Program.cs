using System;
namespace EmpWage
{
   internal class Program
    {
        static void Main(string[] args)

        {
           const int IS_FULL_TIME = 2;
           const int IS_PART_TIME = 1;

            int Rate_Per_Hour = 20;
            int Hrs = 0;
            int wage = 0;

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
            Console.WriteLine("Employee Wage is " + wage);
        }
    }
}