using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment
{
    internal class Pattern4
    {
        static void Main(string[] args)
        {
            Pattern4.NumberPatter1();
        }

        public static void NumberPatter1()
        {
            Console.WriteLine("please enter the row number");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
