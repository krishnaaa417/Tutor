using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern5



    {
        static void Main(string[] args)
        {
            Pattern5.Number2();
        }

        public static void Number2()
        {
            int rows = 7;
            int number = 1;

            for (int i = 1; i <= rows-1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number+++" ");
                }
                Console.WriteLine();
            }
        }
    }
}
