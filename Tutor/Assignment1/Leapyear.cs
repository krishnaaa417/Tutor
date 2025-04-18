using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment1
{
    internal class Leapyear
    {
        static void Main(string[] args)
        {
            Leapyears();
        }

        private static void Leapyears()
        {
            Console.WriteLine("please enter a year");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Yes,your year is a leap year"+","+year);
            }
            else
            {
                Console.WriteLine("sorry,this year is not a leap year"+","+year);
            }
        }
    }
}
