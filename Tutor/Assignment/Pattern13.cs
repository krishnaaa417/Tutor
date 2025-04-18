using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern13
    {
        static void Main(string[] args)
        {
            Pattern13.starPattern();
        }

        public static void starPattern()
        {
            int rows = 7;

            for (int i = 1; i <= rows; i++)
            {
                for (int spaces = 1; spaces <= i; spaces++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= rows - i; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
