using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment2
{
    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            Reverse();
        }

        private static void Reverse()
        {
            Console.WriteLine("please enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int reversenumber = 0;
            while (number > 0)
            {
                int n = number % 10;
                reversenumber = reversenumber * 10 + n;
                number = number / 10;
            }
            Console.WriteLine("ReverseNumber"+reversenumber);
        }
    }
}
