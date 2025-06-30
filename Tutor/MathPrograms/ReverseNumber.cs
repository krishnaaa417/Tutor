using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.MathPrograms
{
    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse-Number.."+Integers(-296));
        }

        private static int Integers(int n)
        {
            int reverse = 0;
            while (n > 0)
            {
                int r = n % 10;
                reverse = reverse * 10 + r;
                n = n / 10;
            }
            return reverse;
        }
    }
}
