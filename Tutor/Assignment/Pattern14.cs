using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern14
    {
        static void Main(string[] args)
        {
            Pattern14.starPattern();
        }

        public static void starPattern()
        {
            int rows = 7;

            for (int i = 1; i <= rows; i++)
            {
                for (int spaces = 1; spaces <= rows - i; spaces++)
                {
                    Console.Write(" ");
                }
                for (int stars = 1; stars <= i; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
