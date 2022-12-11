using System;
namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 20, 80);

            EmpWageBuilderObject Relaince = new EmpWageBuilderObject("Relaince", 18, 24, 100);

            dMart.computeEmpWage();
            Console.WriteLine("");
            Relaince.computeEmpWage();

        }

    }
}
