using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment2
{
    internal class Multiplication
    {
        static void Main(string[] args)
        {
            Mul();
        }

        private static void Mul()
        {
            Console.WriteLine("please enter the number");
            int mul = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{mul} * {i }= {mul * i}");
            }
        }
    }
}
