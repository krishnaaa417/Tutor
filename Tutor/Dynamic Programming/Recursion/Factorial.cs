using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Dynamic_Programming.Recursion
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fact(n));
        }
        private static int Fact(int n)
        {
            if (n == 1) return 1;
            return Fact(n - 1) * n;
        }
    }
}
