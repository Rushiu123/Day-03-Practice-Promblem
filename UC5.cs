using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Practice_Program
{
    internal class UC5
    {
        public static void uc5()
        {
            //Calculating wages for a month

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
                    Console.WriteLine("Part time Employee was present {0} days this month and his Monthly wage is {1}RS", attendance, pmonthlyWage);
                    break;
                case 2:
                    int fmonthlyWage = attendance * fullTimeDailyWage;
                    Console.WriteLine("Full time Employee was present {0} days this month and his Monthly wage is {1}RS", attendance, fmonthlyWage);
                    break;
            }


        }
    }
}
