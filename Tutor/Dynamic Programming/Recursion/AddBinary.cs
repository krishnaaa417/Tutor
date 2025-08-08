using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Dynamic_Programming.Recursion
{
    internal class AddBinary
    {
        static void Main(string[] args)
        {
            string s1 = "11";
            string s2 = "1";
            Console.WriteLine(Binary(s1,s2));
        }

        private static string Binary(string s1, string s2)
        {
            // two pointer approach
            int i = s1.Length - 1;
            int j = s2.Length - 1;
            int carry = 0;

            StringBuilder sb = new StringBuilder();

            while (i >= 0 && j >= 0)
            {
                int a = 0, b = 0;
                if (i >= 0)
                {
                    a = s1[i] - '0';
                    i--;
                }
                if (j >= 0)
                {
                    b = s2[j] - '0';
                    j--;
                }

                int sum = a + b + carry;

                if (sum == 0)
                {
                    sb.Append('0');
                    carry = 0;
                }
                else if (sum == 1)
                {
                    sb.Append('1');
                    carry = 0;
                }
                else if (sum == 2)
                {
                    sb.Append('0');
                    carry = 1;
                }
                else
                {
                    sb.Append('1');
                    carry = 1;
                }
            }
            if (carry == 1)
            {
                sb.Append('1');
            }

            char[] result = sb.ToString().ToCharArray();
            Array.Reverse(result);
            return result.ToString();
        }
    }
}
