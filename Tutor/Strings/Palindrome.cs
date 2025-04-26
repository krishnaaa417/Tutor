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
            palindrome();
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


        

    }
}
