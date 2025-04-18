using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment1
{
    internal class EvenOrOdd
    {
        static void Main(string[] args)
        {
            EvenOrOdds();
        }

        private static void EvenOrOdds()
        {
            Console.WriteLine("please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }
    }
}
