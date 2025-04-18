using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern15
    {
        static void Main(string[] args)
        {
            Pattern15.starPattern();
        }

        public static void starPattern()
        {
            int rows = 6;

            for (int i = 0; i <= rows; i++)
            {
                for (int spaces = 1; spaces <=  i; spaces++)
                {
                    Console.Write(" ");
                }
                for (int number = 1; number <= rows - i; number++)
                {
                    Console.Write(number+i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
