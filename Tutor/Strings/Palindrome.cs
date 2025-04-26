using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Strings
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            // palindrome();
            AnotherApproachToFindPalindrome();
        }

        private static void palindrome()
        {
            Console.WriteLine("please enter a name");
            string name = Console.ReadLine();
            char[] c = name.ToCharArray();

            int left = 0;
            int right = c.Length - 1;

            while (left < right)
            {
                char temp = c[left];
                c[left] = c[right];
                c[right] = temp;

                left++;
                right--;
            }

            string palidromes = new string(c);
            if (name == palidromes)
            {
                Console.WriteLine("Congrats,your given name is a palindrome:-"+name);
            }
            else
            {
                Console.WriteLine("sorry bro :-" + name);
            }
        }


        private static void AnotherApproachToFindPalindrome()
        {
            Console.WriteLine("please enter a string");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();

            int left = 0;
            int right = c.Length - 1;

            for (int i = 0; i < c.Length / 2; i++)
            {
                if (c[left] != c[right])
                {
                    Console.WriteLine("Not a  palindrome.."+s);
                    break;
                }
                else
                {
                    Console.WriteLine("palindrome." + s);
                    break;
                }
            }
           
        }

    }
}
