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
            Occurence();
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
    }
}
