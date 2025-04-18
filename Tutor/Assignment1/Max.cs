using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment1
{
    internal class Max
    {
        static void Main(string[] args)
        {
            MaxofThreeNumber();
        }

        private static void MaxofThreeNumber()
        {
            Console.WriteLine("please enter your first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your second number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter third number");
            int third = Convert.ToInt32(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine("first is largest number");
            }
            else if (second > third && second > first)
            {
                Console.WriteLine("second is the largest number");
            }
            else if (third > second && third > first)
            {
                Console.WriteLine("third is the larfest number");
            }
            else
            {
                Console.WriteLine("all are equal");
            }
        }
    }
}
