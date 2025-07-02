using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DSA_Bootcamp.Basic_Programs
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number..");
            int number = Convert.ToInt32(Console.ReadLine());
            PrintingNumber(number);

        }

        private static void PrintingNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
