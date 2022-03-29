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
            const int Full_Time = 1;
            const int Part_Time = 2;
            const int MAX_WORKING_DAYS = 20;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            Random random = new Random();
            for (int day = 1; day <= MAX_WORKING_DAYS; day++)
            {

                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case Full_Time:
                        Console.WriteLine("employee is present");
                        empHrs = 8;
                        break;
                    case Part_Time:
                        Console.WriteLine("employee is present");
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("Daily Wage :{0} for day{1}", empWage, day);
                totalWage += empWage;
            }
            Console.WriteLine("Total Wage {0} for {1} days", totalWage, MAX_WORKING_DAYS);
            Console.ReadLine();
        }

    }

}
