using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Recursion
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int n = 4;
            Console.WriteLine(Recursion(n));
        }

        private static int BruteForceApproach(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        private static int Recursion(int n)
        {
            if (n == 1) return 1;
            return (n * Recursion(n - 1));
        }
    }
}
/*
 * 5 -> 5*4
------ 20*3
60*2
120*1 120
 */