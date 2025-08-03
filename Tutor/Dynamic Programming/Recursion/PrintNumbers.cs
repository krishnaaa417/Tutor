using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Dynamic_Programming.Recursion
{
    internal class PrintNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OptimizedApproach(5));
        }

        private static int OptimizedApproach(int n)
        {
            //Base condition
            if (n == 0) return n;

            Console.WriteLine("value.."+n);

            return OptimizedApproach(n - 1);

        }
    }
}
