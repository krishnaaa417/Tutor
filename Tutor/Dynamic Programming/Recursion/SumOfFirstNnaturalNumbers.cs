using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Dynamic_Programming.Recursion
{
    internal class SumOfFirstNnaturalNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number..");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---");
            Console.WriteLine(BruteForce(n));
            Console.WriteLine("--Recursion below..");
            Console.WriteLine(usingRecursion(n)); // Updated to correctly call the recursive method  
        }

        private static int BruteForce(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        private static int usingRecursion(int n) 
        {
            if (n == 0) return 0;
            return n+usingRecursion(n-1);
        }
    }
}
