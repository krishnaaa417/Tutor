using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.BitManipulation
{
    internal class PowerOfTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number..");
            int n = Convert.ToInt32(Console.ReadLine());
            OptimizedApproach(n);
        }

        private static bool OptimizedApproach(int n)
        {
            if (n <= 0) return false;

            return ((n & (n - 1)) == 0);
        }
    }
}
