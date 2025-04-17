using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern3
    {
        static void Main(string[] args)
        {
            Pattern3.Pattern3ass();
        }

        public static void Pattern3ass()
        {
            int rows = 7;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= rows-1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
