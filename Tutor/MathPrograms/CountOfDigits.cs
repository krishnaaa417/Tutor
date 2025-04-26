using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.MathPrograms
{
    internal class CountOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Count(n)); ;
        }

        private static int Count(int n)
        {
            int count = 0;
            try
            {
                while (n > 0)
                {
                    n = n / 10;
                    count++;
                }
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }

            return count;


        }
    }
}
