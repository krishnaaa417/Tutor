using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Hallow
{
    internal class HallawPyramid
    {
        static void Main(string[] args)
        {
            HallawPyramid.HallowPyramid();
        }

        public static void HallowPyramid()
        {
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                // Printing leading spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // Printing the hollow pyramid stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    if (k == 1 || k == (2 * i - 1) || i == rows)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
    }

