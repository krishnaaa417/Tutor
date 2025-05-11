using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Strings
{
    internal class Leetcode1662
    {
        static void Main(string[] args)
        {
            string[] word1 = { "ab", "c" };
            string[] word2 = { "a", "bc" };
            string word3 = string.Join("", word1);
            string word4 = string.Join("", word2);
            if (word3 == word4)
            {
                Console.WriteLine("true");
              
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
