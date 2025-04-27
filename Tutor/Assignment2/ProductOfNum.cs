using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment2
{
    internal class ProductOfNum
    {
        static void Main(string[] args)
        {
            int i = 253;

            int product = 1;

            while (i > 1)
            {
                int number = i % 10;
                product = product * number;
                i = i / 10;
            }
            Console.WriteLine(product + "," + "product of numbers");

            
        }
    }
}
