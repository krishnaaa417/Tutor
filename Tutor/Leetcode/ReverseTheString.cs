using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Leetcode
{
    internal class ReverseTheString
    {
        static void Main(string[] args)
        {
            char[] c = { 'H', 'e', 'l', 'l', 'o' };
            for (int i = c.Length - 1; i >= 0; i--)
            {
                Console.Write(c[i]);
            }
        }
    }
}
