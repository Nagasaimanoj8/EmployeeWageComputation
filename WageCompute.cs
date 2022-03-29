using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class WageCompute
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            int isPartTime = 2;
            int empRatePerHr = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empInput = random.Next(0, 3);
            if (isFullTime == empInput)
            {
                Console.WriteLine("employee is present");
                empHrs = 8;

            }
            else if (isPartTime == empInput)
            {
                Console.WriteLine("employee is present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("employee absent");
                empWage = 0;
            }
            empWage = empRatePerHr * empHrs;
            Console.WriteLine("Daily Wage :{0}", empWage);
            Console.ReadLine();
        }
    }
}
