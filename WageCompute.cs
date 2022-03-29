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
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            int totalWage = 0;
            int workingHrs = 0;
            int empHrs = 0;
            int empWage = 0;
            int day = 1;
            Random random = new Random();

            while (day <= MAX_WORKING_DAYS && workingHrs <= MAX_WORKING_HRS)
            {
                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is Present for Full Time");
                        empHrs = 8;
                        break;

                    case IS_PART_TIME:
                        Console.WriteLine("Employee is Present for Part Time");
                        empHrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }


                empWage = EMP_RATE_PER_HOUR * empHrs;
                Console.WriteLine("Daily Wage for day {0} is: {1}", day, empWage);
                totalWage += empWage;
                day++;
                workingHrs += empHrs;
            }



            Console.WriteLine("Total wage for {0} days is :{1} and workingHrs{2}", day, totalWage, workingHrs);
            Console.ReadLine();



        }
    }

}
