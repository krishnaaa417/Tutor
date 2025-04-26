using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Strings
{
    internal class ReverseAString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a string");
            string s = Console.ReadLine();
            Reverse(s);
        }

        private static void Reverse(string s)
        {
            //step 1 = we should convert this string into char Array
            char[] c = s.ToCharArray();
            int i = c.Length - 1;
            while (i >= 0)
            {
                Console.WriteLine(c[i]); ;
                i--;
            }
        }
    }


}
