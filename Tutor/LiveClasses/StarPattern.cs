using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.LiveClasses
{
    internal class StarPattern
    {
        static void Main(string[] args)
        {
            int rows = 6;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("-");
                }
                for (int k = 1; k <= (2 * rows) - 1; k++)
                {
                    if (k == 1 || k == (2 * rows) - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                
            }






        }
    }
}
