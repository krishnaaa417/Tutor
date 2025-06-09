using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Recursion
{
    internal class ReturnOfMaxTwoNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum number.."+Max(1321,2000));
        }

        private static int Max(int a, int b)
        {
            //if (a > b)
            //{
            //    return a;
            //}
            //else
            //{
            //    return b;
            //}

            return (a >b) ? a : b;
        }
    }
}
