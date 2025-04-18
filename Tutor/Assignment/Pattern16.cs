using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern16
    {
        static void Main(string[] args)
        {
            Pattern16.NumberPattern();
        }

        public static void NumberPattern()
        {
            int rows = 6;

            for (int i = 1; i <= rows; i++)
            {
                for (int spaces = 1; spaces < i; spaces++)
                {
                    Console.Write(" ");
                }
                for (int number = i; number <= rows; number++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }

            //for (int i = 1; i <= rows; i++)
            // {
            //     for (int spaces = 0; spaces <= rows - i; spaces++)
            //     {
            //         Console.Write(" ");
            //     }

            //     for (int number = 0; number <= rows - i; number++)
            //     {
            //         Console.Write(rows - number);
            //     }
            //     Console.WriteLine();

            for (int i = rows - 1; i >= 1; i--)
            {
                for (int spaces = 1; spaces < i; spaces++)
                {
                    Console.Write(" ");
                }
                for (int number = i; number <= rows; number++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

