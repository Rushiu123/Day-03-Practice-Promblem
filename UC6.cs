using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Practice_Program
{
    internal class UC6
    {
        public static void uc6()
        {
            //Calculate Wages till a condition of total working hours or days is reached

            int partTimeHour = 8;
            int fullTimeHour = 16;
            int wagePerHour = 20;

            int parttimeDailyWage = partTimeHour * wagePerHour;
            int fullTimeDailyWage = fullTimeHour * wagePerHour;

            Random rand = new Random();

            int attendance = rand.Next(1, 21);


            Console.WriteLine("1.Part Time Employee   2.Full Time Employee");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int pmonthlyWage = attendance * parttimeDailyWage;
                    int pworkingHours = attendance * partTimeHour;
                    Console.WriteLine("Part time Employee was present {0} days and did {2} working hours this month and his Monthly wage is {1}RS", attendance, pmonthlyWage, pworkingHours);
                    break;
                case 2:
                    int fmonthlyWage = attendance * fullTimeDailyWage;
                    int fworkingHours = attendance * fullTimeHour;
                    Console.WriteLine("Full time Employee was present {0} days and did {2} working hours this month and his Monthly wage is {1}RS", attendance, fmonthlyWage, fworkingHours);
                    break;
            }


        }
    }
}
