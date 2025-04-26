using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Strings
{
    internal class Anagrams
    {
        static void Main(string[] args)
        {
            CheckingAnagrams();
        }

        private static void CheckingAnagrams()
        {
            Console.WriteLine("please enter  a first string");
            string s1 = Console.ReadLine();
            Console.WriteLine("please enter a second string");
            string s2 = Console.ReadLine();

            if (s1.Length != s2.Length)
            {
                Console.WriteLine("not a anagram");
                return;
            }

            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            if (new string(c1) == new string(c2))
            {
                Console.WriteLine("Yes,it a anagram.." + s1);
            }
            else
            {
                Console.WriteLine("not a anagram" + s2);
            }
        }
    }
}
