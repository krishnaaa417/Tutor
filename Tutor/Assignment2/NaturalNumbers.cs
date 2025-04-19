using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment2
{
    internal class NaturalNumbers
    {
        static void Main(string[] args)
        {
            SumOfNaturalNumbers();
        }

        private static void SumOfNaturalNumbers()
        {
            int n = 10;
            int numbers = n * (n + 1) / 2;
            Console.WriteLine("the sum of first 10 natural numbers.."+numbers);
        }
    }
}
