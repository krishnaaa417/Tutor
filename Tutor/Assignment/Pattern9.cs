using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern9
    {
        static void Main(string[] args)
        {
            starPattern();
        }

        public static void starPattern()
        {
            int rows = 7;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
