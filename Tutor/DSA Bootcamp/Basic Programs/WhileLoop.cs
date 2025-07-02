using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DSA_Bootcamp.Basic_Programs
{
    internal class WhileLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            EvenNumber(number);
        }

        private static void EvenNumber(int number)
        {
            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }
    }
}
