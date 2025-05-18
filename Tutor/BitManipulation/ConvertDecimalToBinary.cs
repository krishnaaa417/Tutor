using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.BitManipulation
{
    internal class ConvertDecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number.");
            int n = Convert.ToInt32(Console.ReadLine());
            string b = "";

            while (n >= 1)
            {
                int x = n % 2;
                n = n / 2;
                b = x + b;
            }

            Console.WriteLine(b);

            Console.WriteLine(BinaryTodecimal(b));
            
        }

        public static int BinaryTodecimal(string s)
        {
            int number = 0;
            int power = 1;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '1')
                {
                    number = number + power;
                }
                power = power * 2;
            }
           
            return number;
        }
    }
}
