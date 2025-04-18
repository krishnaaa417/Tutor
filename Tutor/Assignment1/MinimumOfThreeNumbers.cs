using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment1
{
    internal class MinimumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            MinimumThreeNumbers();
        }

        private static void MinimumThreeNumbers()
        {
            Console.WriteLine("please enter first number");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter third number");
            int three = Convert.ToInt32(Console.ReadLine());

            if (one < two && one < three)
            {
                Console.WriteLine(one + "," + "Is minimum number");
            }
            else if (two < one && two < three)
            {
                Console.WriteLine(two + "," + "Is minimum number");

            }
            else if (three < one && three < two)
            {
                Console.WriteLine(three + "," + "Is minimum number ");
            }
            else
            {
                Console.WriteLine("All are equal");
            }
        }
    }
    }
