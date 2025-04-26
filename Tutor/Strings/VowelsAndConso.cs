using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Strings
{
    internal class VowelsAndConso
    {
        static void Main(string[] args)
        {
            NumberOfVowelsAndConsoants();
        }

        private static void NumberOfVowelsAndConsoants()
        {
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            int count = 0;
            int consonants = 0;

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 'a' || c[i] == 'e' || c[i] == 'i' || c[i] == 'o' || c[i] == 'u')
                {
                    count++;
                }
                else
                {
                    consonants++;
                }
            }
            Console.WriteLine("Number of vowels are presented in a given string//::-" + count);
            Console.WriteLine("Number of CONSONANTS are presented in a given string..."+ consonants);
        }
    }
}
