using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.BitManipulation
{
    internal class FindingNumberIsAEvenOrOddByUsingBitManipulation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number..");
            int n = Convert.ToInt32(Console.ReadLine());
            if ((n & 1) != 0)
            {
                Console.WriteLine("your number is an ODD NUMBER.."+n);
            }
            else
            {
                Console.WriteLine("Your number is an Even number.."+n);
            }
        }
    }
}
