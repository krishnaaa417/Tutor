using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern2
    {
        static void Main(string[] args)
        {
            Pattern2.LeftAlign();
        }

        public static void LeftAlign()
        {
            Console.WriteLine("please enter the rows number");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = i; k >= 1; k--)
                {
                    Console.Write(k);
                }

                for(int s = 2; s <= i;  s++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
        }
    }
}
