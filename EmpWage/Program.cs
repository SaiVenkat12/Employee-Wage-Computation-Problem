using System;
namespace EmpWage
{
   internal class Program
    {
        static void Main(string[] args)

        {
            int IS_FULL_TIME = 2;
            int Is_PART_TIME = 1;
            int Rate_Per_Hour = 20;
            int Hrs = 0;
            int wage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                Hrs = 8;
            }
            else if (empCheck == Is_PART_TIME) 
            {
                Hrs = 4;
            }
            else
            {
                Hrs = 0;
            }
            wage = Hrs * Rate_Per_Hour;
            Console.WriteLine("Employee Wage is " + wage);
        }
    }
}