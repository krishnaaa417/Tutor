using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment2
{
    internal class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            // NewMethod();
            Fact();
        }

        private static void NewMethod()
        {
            Console.WriteLine("Enter a number (N) to display first N odd numbers:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"First {n} odd numbers:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write((2 * i - 1) + " ");
            }
        }

        private static void Fact()
        {
            Console.WriteLine("please enter a number");
            int fact = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= fact; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
