using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Strings
{
    internal class LeetcodePalindrome
    {
        static void Main(string[] args)
        {
            string[] words = { "abc", "car", "ada", "racecar", "cool" };

            for (int i = 0; i < words.Length; i++)
            {
                if (IsPalindome(words[i]) == true)
                {
                    Console.WriteLine(words[i]);
                    break;
                }
            }
        }

        private static bool IsPalindome(string word)
        {
           
            int n = word.Length;
            // here I'm using two pointer approach to find the palindrome

            int left = 0;
            int right = n - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;


            
        }
    }
}
