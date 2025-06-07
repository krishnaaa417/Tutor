using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.LiveClasses
{
    internal class _3rdclass
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Add(10, 20)); ;
            Console.WriteLine(Sub(10, 20)); ;
            Console.WriteLine(Mul(10, 20)); ;
            Console.WriteLine(Div(10, 20));;
            Console.WriteLine(Mod(10, 20) );

            //int rows = 6;
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int star = 1; star <= rows - i; star++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////for (int i = 2; i <= rows; i++)
            ////{
            ////    for (int star = 2; star <= i+1; star++)
            ////    {
            ////        Console.Write("*");
            ////    }
            ////    Console.WriteLine();
            ////}

            //for (int i = 2; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int star = 1; star <= (2 * i) - 1; star++)
            //    {
            //        if (star == 1 || star == (2 * i) - 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }

            //    Console.WriteLine();
            //}
            //for (int star = 1; star <= rows; star++)
            //{
            //    Console.Write("* ");
            //}

            //int input = 123;
            //int sum = 0;

            //while (input > 0)
            //{
            //    int number = input % 10;
            //    sum += number;
            //    input = input / 10;
            //}

            //Console.WriteLine(sum);
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static int Sub(int a, int b)
        {
            return (a - b);
        }

        private static int Div(int a, int b)
        {
            return a / b;
        }

        private static int Mul(int a, int b)
        {
            return a * b;
        }

        private static int Mod(int a, int b)
        {
            return a % b;
        }
    }
}
