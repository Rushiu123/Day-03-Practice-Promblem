using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Practice_Program
{
    internal class UC2
    {
        public static void uc2()
        {
            //Daily employee wage 
            int wagePerHour = 20;
            int fullDayHour = 8;

            int dailyWage = wagePerHour * fullDayHour;

            int Present = 1;
            int Absent = 0;

            Random rand = new Random();

            int Attendance = rand.Next(0, 2);

            //Attendance checking 
            if (Attendance == Absent)
            {
                Console.WriteLine("Employee is absent so no daily wage is given");
            }
            if (Attendance == Present)
            {
                Console.WriteLine("Employee is present his daily wage is {0}RS", dailyWage);
            }

        }
    }
}
