using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.BitManipulation
{
    internal class NumberOf1Bits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number..");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(OptimisedApproach(n)); ;
        }

        private static int OptimisedApproach(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n = n & (n - 1);
                count++;
            }
            return count;
        }
    }
}
