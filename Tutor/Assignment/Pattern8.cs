using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern8
    {
        static void Main(string[] args)
        {
            StarPattern();
        }

        public static void StarPattern()
        {
            int rows = 6; // Half the pattern height

            // Upper Triangle
            for (int i = 1; i <= rows; i++)
            {
                for (int star = 1; star <= i; star++)
                {
                    Console.Write("*");
                }
                for (int spaces = 1; spaces <= (rows - i) * 2; spaces++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= i; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Middle Rows
            for (int i = 1; i <= rows * 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 1; i <= rows * 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // Lower Triangle
            for (int i = rows; i >= 1; i--)
            {
                for (int star = 1; star <= i; star++)
                {
                    Console.Write("*");
                }
                for (int spaces = 1; spaces <= (rows - i) * 2; spaces++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= i; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
