using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Queues
{
    internal class FindtheNonRepeativeCharacter
    {
        static void Main(string[] args)
        {
            string s = "swiss";
            char result = GetNonRepeatingcharacter(s);

            if (result != '\0')
            {
                Console.WriteLine("First Non-repeating character.." + result);
            }
            else
            {
                Console.WriteLine("No non-repeating character found..");
            }
        }

        private static char GetNonRepeatingcharacter(string s)
        {
            int[] freq = new int[256];

            // Count character frequencies
            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i]]++;
            }

            //return first character with frequency 1

            for (int i = 0; i < s.Length; i++)
            {
                if (freq[s[i]] == 1)
                {
                    return s[i];
                }
            }
            return '\0';
        }
    }
}
