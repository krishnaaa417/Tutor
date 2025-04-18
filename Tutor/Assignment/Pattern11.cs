using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern11
    {
        static void Main(string[] args)
        {
            Pattern11.StarPattern();
        }
        public static void StarPattern()
        {
            int rows = 7;

            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <=  i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
