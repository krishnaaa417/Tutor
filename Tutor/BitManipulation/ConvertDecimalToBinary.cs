using System;
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
            
        }
    }
}
