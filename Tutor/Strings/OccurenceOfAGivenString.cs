using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Strings
{
    internal class OccurenceOfAGivenString
    {
        static void Main(string[] args)
        {
            //Occurence();
            NonMatchingCharctersInaString();
        }

        private static void Occurence()
        {
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            char k = 'a';
            int count = 0;

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == k)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void NonMatchingCharctersInaString()
        {
            string s = Console.ReadLine();
           // char[] c = s.ToCharArray();
            bool b;

            for (int i = 0; i < s.Length; i++)  // i =0
            {
                // I'm assuming each and every character is unique
                b = true;

                for (int j = 0; j < s.Length; j++)
                {
                   if (i != j && s[i] == s[j])
                    {
                        b = false;
                        break;
                    }
                }

                if (b)
                {
                    Console.WriteLine(s[i]);
                }
            }
           
        }
    }
}
