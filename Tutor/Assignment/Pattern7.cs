using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern7
    {
        static void Main(string[] args)
        {
            Pattern7.starPattern();
        }
        //     *
        //    ***
        //   *****
        //  *******
        // *********
        //***********
        // *********
        //  *******
        //   *****
        //    ***
        //     *
        public static void starPattern()
        {
            int rows = 9;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= 2 * i - 1; star++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

        }
    }
}




