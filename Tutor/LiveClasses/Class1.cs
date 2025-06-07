using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.LiveClasses
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //int rows = 6;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int spaces = 1; spaces <= i; spaces++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int number = 1; number <= rows - i; number++)
            //    {
            //        Console.Write(number + i + " ");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 2; i < rows; i++)
            //{
            //    for (int spaces = 1; spaces <= rows - i; spaces++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int number = 1; number <= i; number++)
            //    {
            //        Console.Write(rows-i+1+" ");
            //    }
            //    Console.WriteLine();
            //}

            int n = 4;
            int value = 1;

            for (int i = 1; i <= n; i++)
            {
                value = value * 2;
            }
            Console.WriteLine(value);

        }
    }
}
