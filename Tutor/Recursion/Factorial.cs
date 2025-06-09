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
            Console.WriteLine(Factors(5));
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

        private  static int Factors(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
/*
 * 5 -> 5*4
------ 20*3
60*2
120*1 120
 */