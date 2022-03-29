using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyEmployeeWage
{
    internal class DailyWage
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            int empRatePerHr = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empInput=random.Next(0,2);
            if(isPresent == empInput)
            {
                Console.WriteLine("employee is present");
                empHrs = 8;

            }
            else
            {
                Console.WriteLine("employee absent");
            }
            empWage = empRatePerHr * empHrs;
            Console.WriteLine("Daily Wage:{0}",empWage);
            Console.ReadLine();
        }
    }
}
