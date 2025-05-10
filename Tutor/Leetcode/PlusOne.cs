using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Leetcode
{
    internal class PlusOne
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please enter an array size");
            int[] ints = { 1,2,3 };

            Console.WriteLine(string.Join(", ", plusOne(ints)));

            // expected output = {1,2,9}
        }

        private static int[] plusOne(int[] digits)
        {
           
           for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    return digits;
                }
            }
            //edge case
            int[] result = new int[digits.Length+1];
            result[0] = 1;
            return result;

        }
    }
}
