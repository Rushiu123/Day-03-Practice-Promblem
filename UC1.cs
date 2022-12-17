using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Practice_Program
{
    internal class UC1
    {
        public static void Uc1()
        {
            Random rnd = new Random();
            int num = rnd.Next(2);

            if (num == 0)
            {
                Console.WriteLine("Student is absent");
            }
            else
            {
                Console.WriteLine("Student is present");
            }
        }
    }
}


