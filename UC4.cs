using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Practice_Program
{
    internal class UC4
    {
        public static void uc4()
        {
            //Solving using Switch case statement

            int partTimeHour = 8;
            int fullTimeHour = 16;
            int wagePerHour = 20;

            int partTimeDailyWage = partTimeHour * wagePerHour;
            int fullTimeDailyWage = fullTimeHour * wagePerHour;

            Random rand = new Random();

            int attendance = rand.Next(0, 2);

            int present = 1;
            int absent = 0;

            Console.WriteLine("1.Part Time Employee   2.Full Time Employee");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    if (attendance == present)
                    {
                        Console.WriteLine("Part time Employee is present his daily wage is {0}RS", partTimeDailyWage);
                    }
                    if (attendance == absent)
                    {
                        Console.WriteLine("Parttime Employee is Absent so no daily wage");
                    }
                    break;

                case 2:
                    if (attendance == present)
                    {
                        Console.WriteLine("Full time Employee is present his daily wage is {0}RS", fullTimeDailyWage);
                    }
                    else
                    {
                        Console.WriteLine("Full time Employee is absent so no daily wage");
                    }
                    break;
            }
        }
    }
}
