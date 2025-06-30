using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Arrays
{
    internal class AddDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

        }

        private static int OptimizedOne(int num)
        {
            if (num < 0) return 0;

            while (num > 9)
            {
                int sum = 0;

                while (num > 0)
                {
                    sum = sum + num % 10;
                    num /= 10;
                }
                num = sum;
            }
            return num;
        }
    }
}
