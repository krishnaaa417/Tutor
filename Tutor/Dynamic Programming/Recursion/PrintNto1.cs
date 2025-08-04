using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Dynamic_Programming.Recursion
{
    internal class PrintNto1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your number..");
            int n = Convert.ToInt32(Console.ReadLine());
            HeadRecursion(n);
            Console.WriteLine("---------------");
            TailRecursion(n);
        }
        
        private static void HeadRecursion(int n)
        {
            //Base condition
            if (n == 0) return ;
            HeadRecursion(n-1);
            Console.WriteLine(n);
        }
        private static void TailRecursion(int n)
        {
            //Base condition
            if (n == 0) return;
            Console.WriteLine(n);
            HeadRecursion(n - 1);
            
        }
    }
}
