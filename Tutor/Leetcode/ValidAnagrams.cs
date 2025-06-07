using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Leetcode
{
    internal class ValidAnagrams
    {
        static void Main(string[] args)
        {
            string s1 = "anagram";
            string s2 = "nagaram";
            Console.WriteLine(s1.Contains(s2));
        }
    }
}
