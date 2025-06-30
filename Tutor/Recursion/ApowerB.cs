using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Recursion
{
    internal class ApowerB
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 44, 4432, 22222, 0 };
            int temp = a[0];
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                if (temp < a[i])
                {
                    temp = a[i];
                }
            }
            Console.WriteLine("Maximum number in the array.."+temp);
        }

        private static int BruteForceApproach(int a, int b)
        {
            int power = 1;
            for (int i = 1; i <= b; i++)
            {
                power *= a;
            }
            return power;
        }

    }
}
