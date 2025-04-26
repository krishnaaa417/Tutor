using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Strings
{
    internal class CalculateANumberInagivenstring
    {
        static void Main(string[] args)
        {
            //NumberInStrings();
            AnotherApproach();
        }

        private static void NumberInStrings() //I written
        {
            string s = "venka23t4";
            char[] chars = s.ToCharArray();
            int sum = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '1' || chars[i] == '2' || chars[i] == '3' || chars[i] == '4' || chars[i] == '5' || chars[i] == '6' || chars[i] == '7' || chars[i] == '8' || chars[i] == '9')
                {
                    sum = sum + chars[i] - '0';
                }
            }
            Console.WriteLine(sum);
        }

        private static void AnotherApproach()
        {

            Console.WriteLine("please enter a string");
            string s = Console.ReadLine();
            int sum = 0;

            foreach (char c in s)
            {
                if (char.IsDigit(c))  // Simplified condition
                {
                    sum += c - '0';  // Convert character to its numerical value
                }
            }

            Console.WriteLine("Sum of digits: " + sum);

        }
    }
}
