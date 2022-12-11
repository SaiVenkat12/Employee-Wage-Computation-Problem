using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string comp;
        private int empRH;
        private int WDays;
        private int MHrs;
        public int tew;

        public EmpWageBuilderObject(string company, int empRatePerHrs, int numOfWorkingDays, int maxHrsPerMonth)
        {
            comp = company;
            empRH = empRatePerHrs;
            WDays = numOfWorkingDays;
            MHrs = maxHrsPerMonth;
        }
        public void computeEmpWage()
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs < MHrs && totalWorkingDays < WDays)
            {

                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                totalWorkingDays ++;

            }
            int totalEmpWage = totalEmpHrs * empRH;
            Console.WriteLine("No.of Hours = " + totalEmpHrs + " and" + " No.of Working Days = " + WDays);
            Console.Write("Total Employee Wage of the company " + comp + "  is " + totalEmpWage);

        }
    }
}
